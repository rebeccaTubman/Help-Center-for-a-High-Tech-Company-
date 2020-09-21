using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using HPHelpCenter;
using HPHelpCenter.Models;

namespace Dal
{
    class ItemHandler
    {
        
    /// <summary>
    /// The item DO  handler implementation.
        public class UserHandler : BusinessObjectHandler<Item>
        {
            public UserHandler(DBHelper dbHelper) : base(dbHelper) { }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override String GetFields()
            {
                return "[ID], [ItemName], [Company], [Type], [Amount], [MinAmount], [ReleaseDate]";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override String GetTableName()
            {
                return " [Item] ";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override Item BuildEntity(DbDataReader reader)
            {
                Item item = new Item(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    reader.GetInt32(5),
                    reader.GetDateTime(6)
                    );
                return item;
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetCreateQuery(Item entity)
            {
                return "INSERT INTO [Item] (" +
                    GetFields() +
                    ") VALUES (@ID, @ItemName, @Company, @Type, @Amount, @MinAmount, @ReleaseDate)";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetUpdateQuery(Item entity)
            {
                return "UPDATE [Item] SET  [ID]=@ID , [ItemName]=@ItemName, [Company]=@Company, [Type]=@Type, [Amount]=@Amount, [MinAmount]=@MinAmount, [ReleaseDate]=@ReleaseDate WHERE [ID]=@ID";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetDeleteQuery(Item entity)
            {
                return "DELETE [Item] WHERE [ID] = @ID ";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetSelectByIdQuery()
            {
                return "SELECT " + GetFields() + " FROM [Item] WHERE [ID] = @ID ";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// @ID, @ItemName, @Company, @Type, @Amount, @MinAmount, @ReleaseDate
            /// </summary>
            protected override DbParameter[] CreateDbParameter(Item item)
            {
                //UserData user = (UserData)entity;
                DbParameter[] parameters = new DbParameter[7];
                parameters[0] = DBHelper.GetParameter("@ID", item.Id);
                parameters[1] = DBHelper.GetParameter("@ItemName", item.ItemName);
                parameters[2] = DBHelper.GetParameter("@Company", item.Company);
                parameters[3] = DBHelper.GetParameter("@Type", item.Type);
                parameters[4] = DBHelper.GetParameter("@Amount", item.Amount);
                parameters[5] = DBHelper.GetParameter("@MinAmount", item.MinAmount);
                parameters[6] = DBHelper.GetParameter("@ReleaseDate", item.ReleaseDate);
                return parameters;

            }
        }
    }
}
