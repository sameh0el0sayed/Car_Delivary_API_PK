using Car_Delivary_API.Mapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Delivary_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaulteDriverAdmin : Migration
    {
        const string userID = "f6340718-6003-4b99-8e83-fb8ebeaa7ddf_DD";
        const string DriverID = "f6340718-6003-4b99-8e83-fb8ebeaa7ddf_DD_01";
        const string userRoleID = "dabb3c64-0ae5-4df8-8d44-c3f97fcaa2df_DD";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            //normal user

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                 columns: new[] { "Id", "UserName", "NormalizedUserName", "Email",
                     "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp",
                     "AccessFailedCount", "TwoFactorEnabled", "LockoutEnabled",  "PhoneNumberConfirmed"  },
                values: new object[] { userID, "user", "firstdriver".ToUpperInvariant(), "firstdriver@email.com", "firstdriver@email.com".ToUpper(),true,
                hasher.HashPassword(null, "userpassword"),string.Empty,0,false,false, false
                });

            migrationBuilder.InsertData(
              table: "AspNetRoles",
               columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
              values: new object[] { userRoleID, ApplicationRoleName.DriverRoleName, ApplicationRoleName.DriverRoleName.ToUpper(), userRoleID });


            migrationBuilder.InsertData(
              table: "AspNetUserRoles",
               columns: new[] { "UserId", "RoleId" },
              values: new object[] { userID, userRoleID });


            migrationBuilder.InsertData(
             table: "Driver",
                schema: "API",
            columns: new[] { "DriverID", "VehicleID", "UserId", "DriverLicenseNo", "IsActive" },
           values: new object[] { DriverID, "", userID, 0, true });



        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id" },
                keyValues: new object[] { userID }); 

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id" },
                keyValues: new object[] { userRoleID });

            migrationBuilder.DeleteData(
                 table: "Driver",
                 schema: "API",
                 keyColumns: new[] { "DriverID" },
                 keyValues: new object[] { DriverID });
        }
    }
}
