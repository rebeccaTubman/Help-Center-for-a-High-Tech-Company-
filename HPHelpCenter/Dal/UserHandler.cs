using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using HPHelpCenter;

namespace Dal
{

    /// <summary>
    /// The user DO  handler implementation.

    public class UserHandler : BusinessObjectHandler<User>
    {
        public UserHandler(DBHelper dbHelper) : base(dbHelper) { }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override String GetFields()
        {
            return "[ID], [FirstName], [LastName], [UserName], [Role], [BirthdayDate], [Country], [Gender], [Email], [Password], [IsDeleted], [PictureID]"; // +PictureID
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override String GetTableName()
        {
            return " [User] ";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override User BuildEntity(DbDataReader reader)
        {
            User user = new User(
                reader.GetInt32(0), 
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3),
                (User.UserRole)Enum.Parse(typeof(User.UserRole), reader.GetString(4), true),
                reader.GetDateTime(5),
                (User.UserCountry)Enum.Parse(typeof(User.UserCountry), reader.GetString(6), true),
                (User.UserGender)Enum.Parse(typeof(User.UserGender), reader.GetString(7), true),
                reader.GetString(8),
                reader.GetString(9),
                reader.GetBoolean(10),
                reader.IsDBNull(11)? 0 : reader.GetInt32(11)
                );
            return user;
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetCreateQuery(User entity)
        {
            return "INSERT INTO [User] (" + 
                GetFields() +
                ") VALUES (@ID, @FirstName, @LastName, @UserName, @Role, @BirthdayDate, @Country, @Gender, @Email, @Password, @IsDeleted, @PictureID)";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetUpdateQuery(User entity)
        {
            return "UPDATE [User] SET  [ID]=@ID , [FirstName]=@FirstName, [LastName]=@LastName, [UserName]=@UserName, [Role]=@Role, [BirthdayDate]=@BirthdayDate, [Country]=@Country, [Gender]=@Gender, [Email]=@Email, [Password]=@Password, [IsDeleted]=@IsDeleted, [PictureID]=@PictureID WHERE [ID]=@ID";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetDeleteQuery(User entity)
        {
            return "DELETE [User] WHERE [ID] = @ID ";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetSelectByIdQuery()
        {
            return "SELECT " + GetFields() + " FROM [User] WHERE [ID] = @ID";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// @ID, @FirstName, @LastName, @UserName, @Role, @BirthdayDate, @Country, @Gender, @Email, @Password
        /// </summary>
        protected override DbParameter[] CreateDbParameter(User user)
        {
            //UserData user = (UserData)entity;
            DbParameter[] parameters = new DbParameter[12];
            parameters[0] = DBHelper.GetParameter("@ID", user.ID);
            parameters[1] = DBHelper.GetParameter("@FirstName", user.FirstName);
            parameters[2] = DBHelper.GetParameter("@LastName", user.LastName);
            parameters[3] = DBHelper.GetParameter("@UserName", user.UserName);
            parameters[4] = DBHelper.GetParameter("@Role", user.Role);
            parameters[5] = DBHelper.GetParameter("@BirthdayDate", TruncateDateTime(user.BirthdayDate));
            parameters[6] = DBHelper.GetParameter("@Country", user.Country);
            parameters[7] = DBHelper.GetParameter("@Gender", user.Gender);
            parameters[8] = DBHelper.GetParameter("@Email", user.Email);
            parameters[9] = DBHelper.GetParameter("@Password", user.Password);
            parameters[10] = DBHelper.GetParameter("@IsDeleted", user.IsDeleted);
            parameters[11] = DBHelper.GetParameter("@PictureID", user.PictureID);
            return parameters;

        }

        /// <summary>
        /// Get user by user name
        /// </summary>
        /// <param name="username">username</param>
        /// <returns>list of users</returns>
        public virtual List<User> GetUsersByUserName(String username)
        {
            String query = "SELECT " + GetFields() + " FROM [User] WHERE ([Username] like '%" +
                username + "%' or [FirstName] like '%" + username + "%' or [LastName] like '%" + username + "%') AND [IsDeleted] = 0";

            DbParameter[] parameters = new DbParameter[0];
            List<User> datas = GetBusinessEntitiesByCriteria(query, parameters);
            return datas;
        }

        /// <summary>
        /// get user by username and password. (Used in perspective) in order to 
        /// protect password from hacker attacks.
        /// Basicaly password should be encodded when inserted or used as query parameter 
        /// and nulled when user data returned to the business layer.
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="pwd">password</param>
        /// <returns>user</returns>
        public virtual User GetUsersByUserNameAndPassword(String username, String pwd)
        {
            String query = "SELECT " + GetFields() + " FROM [User] WHERE [UserName] = @UserName AND [Password] = @Password AND [IsDeleted] = 0";
            //String query = "SELECT UserName FROM User ";
            DbParameter[] parameters = new DbParameter[2];
            parameters[0] = DBHelper.GetParameter("@UserName", username);
            parameters[1] = DBHelper.GetParameter("@Password", pwd);
            //IsDeleted
            User data = (User)GetSingleBusinessEntityByCriteria(query, parameters);
            return data;
        }

        internal List<User> GetAllUsers()
        {
            String query = "SELECT " + GetFields() + " FROM [User] WHERE [IsDeleted] = 0 ";
            //String query = "SELECT UserName FROM User ";
            DbParameter[] parameters = new DbParameter[0];
            List<User> data = GetBusinessEntitiesByCriteria(query, parameters);
            return data;
        }
    }
}
