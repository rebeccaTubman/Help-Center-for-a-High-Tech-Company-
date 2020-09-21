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

    /// <summary>
    /// The picture DO  handler implementation.
        public class PictureHandler : BusinessObjectHandler<Picture>
        {
            public PictureHandler(DBHelper dbHelper) : base(dbHelper) { }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override String GetFields()
            {
                return "[ID], [Picture], [IsDeleted]";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override String GetTableName()
            {
                return " [Picutre] ";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override Picture BuildEntity(DbDataReader reader)
            {
                Picture picture = new Picture(
                    reader.GetInt32(0),
                    (byte[])reader.GetValue(1),
                    reader.GetBoolean(2)
                    );
                return picture;
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetCreateQuery(Picture entity)
            {
                return "INSERT INTO [Picture] (" +
                    GetFields() +
                    ") VALUES (@ID, @Picture, @IsDeleted)";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetUpdateQuery(Picture entity)
            {
                return "UPDATE [Picture] SET  [ID]=@ID , [Picture]=@Picture, [IsDeleted]=@IsDeleted WHERE [ID]=@ID";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetDeleteQuery(Picture entity)
            {
                return "DELETE FROM [Picture] WHERE [ID] = @ID ";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetSelectByIdQuery()
            {
                return "SELECT " + GetFields() + " FROM [Picture] WHERE [ID] = @ID ";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// @ID, @ItemName, @Company, @Type, @Amount, @MinAmount, @ReleaseDate
            /// </summary>
            protected override DbParameter[] CreateDbParameter(Picture item)
            {
                //UserData user = (UserData)entity;
                DbParameter[] parameters = new DbParameter[3];
                parameters[0] = DBHelper.GetParameter("@ID", item.ID);
                parameters[1] = DBHelper.GetParameter("@Picture", item.Img);
                parameters[2] = DBHelper.GetParameter("@IsDeleted", item.IsDeleted);
                return parameters;

            }
        }
}
