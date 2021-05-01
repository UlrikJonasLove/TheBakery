
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bageriet.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "isProductOfTheWeek",
                table: "Products",
                newName: "IsProductOfTheWeek");

            migrationBuilder.RenameColumn(
                name: "imageThumbnailUrl",
                table: "Products",
                newName: "ImageThumbnailUrl");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Bröd", null },
                    { 2, "Kakor", null },
                    { 3, "Tårtor", null },
                    { 4, "Mat", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsProductOfTheWeek", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Riktigt gott bröd!", "https://goldbelly.imgix.net/uploads/merchant/main_image/778/hot-bread-kitchen.05560fd0bcbc5b3bb726f649c9ee7124.jpg?ixlib=react-8.6.4&auto=format&fit=crop&h=534&w=1150", "https://goldbelly.imgix.net/uploads/merchant/main_image/778/hot-bread-kitchen.05560fd0bcbc5b3bb726f649c9ee7124.jpg?ixlib=react-8.6.4&auto=format&fit=crop&h=534&w=1150", true, "Bagarens favorit!" },
                    { 2, 1, "Riktigt gott surdegsbröd!", "https://mittkok.expressen.se/wp-content/uploads/2016/04/surdeg.jpg", "https://mittkok.expressen.se/wp-content/uploads/2016/04/surdeg.jpg", true, "Surdegsbröd!" },
                    { 3, 1, "Mörkt sommarbröd med bär!", "https://img.koket.se/media/morkt-sommarbrod.jpg", "https://img.koket.se/media/morkt-sommarbrod.jpg", true, "Sommarhimlen" },
                    { 4, 2, "Kaka med choklad!", "https://www.jennysmatblogg.nu/wp-content/uploads/img_1974-2.jpg", "https://www.jennysmatblogg.nu/wp-content/uploads/img_1974-2.jpg", true, "Chokladrutor" },
                    { 5, 2, "Smarrig äppelkaka!", "https://www.viaventri.se/wp-content/uploads/2018/08/IMG_4970-kopia.jpg", "https://www.viaventri.se/wp-content/uploads/2018/08/IMG_4970-kopia.jpg", true, "Äppelkaka" },
                    { 6, 2, "Bästa sockerkakan i Sverige!", "https://img.koket.se/media/hur-bakar-man-sockerkaka.jpg", "https://img.koket.se/media/hur-bakar-man-sockerkaka.jpg", true, "Sockerkaka" },
                    { 7, 3, "Tårta med marängsmörkräm!", "https://img.koket.se/media/fantastiska-tartor.jpg", "https://img.koket.se/media/fantastiska-tartor.jpg", true, "Hallontårta" },
                    { 8, 3, "Tårta med smak av jasmin!", "https://img.koket.se/mobile/stencildekoration-pa-tarta-se-gor.jpg", "https://img.koket.se/mobile/stencildekoration-pa-tarta-se-gor.jpg", true, "Jasmintårta" },
                    { 9, 3, "Chokladtårta med utsökt delikatess!", "https://www.kenwoodworld.com/Global/recipes/Recipe%20Images/titanium/Chocolate-Cake.jpg", "https://www.kenwoodworld.com/Global/recipes/Recipe%20Images/titanium/Chocolate-Cake.jpg", true, "Paradistårta" },
                    { 10, 4, "Pizza med italiensk pepperoni!", "https://img1.cookinglight.timeinc.net/sites/default/files/styles/medium_2x/public/1563392585/pepperoni-skillet-pizza-1907.jpg?itok=l_08ukf0", "https://img1.cookinglight.timeinc.net/sites/default/files/styles/medium_2x/public/1563392585/pepperoni-skillet-pizza-1907.jpg?itok=l_08ukf0", true, "Pepperoni pizza" },
                    { 11, 4, "Vegetarisk pizza med mozerella", "https://st2.depositphotos.com/4208641/7406/i/950/depositphotos_74061695-stock-photo-vegetarian-pizza-with-mozzarella-and.jpg", "https://st2.depositphotos.com/4208641/7406/i/950/depositphotos_74061695-stock-photo-vegetarian-pizza-with-mozzarella-and.jpg", true, "Vegetarisk pizza" },
                    { 12, 4, "Supergod pizza med skinka och ost!", "https://imgs.aftonbladet-cdn.se/v2/images/26753b77-44ff-4d8b-bfb6-cf57fe26ecac?fit=crop&h=442&q=50&w=600&s=89af9ba3747ae09a577ca1b8e81e10543bde2a32", "https://imgs.aftonbladet-cdn.se/v2/images/26753b77-44ff-4d8b-bfb6-cf57fe26ecac?fit=crop&h=442&q=50&w=600&s=89af9ba3747ae09a577ca1b8e81e10543bde2a32", true, "Vesuvio pizza" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "IsProductOfTheWeek",
                table: "Products",
                newName: "isProductOfTheWeek");

            migrationBuilder.RenameColumn(
                name: "ImageThumbnailUrl",
                table: "Products",
                newName: "imageThumbnailUrl");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
