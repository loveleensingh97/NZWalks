using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2cc0f7e6-7916-47fc-902d-3892666ecfa4"), "Hard" },
                    { new Guid("529e8a1e-eb80-451a-a5a4-5a9a89f88350"), "Medium" },
                    { new Guid("fe58ef6d-3957-42bd-84eb-fb5984250b98"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("3b0fe77b-2431-4471-a813-3ed206b78e8f"), "AKL", "Auckland", "https://www.google.com/imgres?q=3d%20images%20hd&imgurl=https%3A%2F%2Fwallpapers.com%2Fimages%2Fhd%2F3d-hd-tree-cup-miniature-3afg373o0vwa5dxq.jpg&imgrefurl=https%3A%2F%2Fwallpapers.com%2F3d-hd&docid=a3PZgobyCyc-JM&tbnid=d1p9NgPNR71PHM&vet=12ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECBUQAA..i&w=1920&h=1200&hcb=2&ved=2ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECBUQAA" },
                    { new Guid("5199f117-ad9f-469f-91c8-3311b9b1f84d"), "NTL", "Northland", null },
                    { new Guid("5c237922-5fdc-4789-ae75-e2eadaa8269b"), "STL", "Southland", null },
                    { new Guid("69c60c7a-cd16-4b36-bc2f-3fba45f02e89"), "WGN", "Wellington", "https://www.google.com/imgres?q=3d%20images%20hd&imgurl=https%3A%2F%2Fimg.freepik.com%2Ffree-photo%2Fcloseup-textural-bright-exotic-flowers-generative-al_169016-28578.jpg&imgrefurl=https%3A%2F%2Fwww.freepik.com%2Ffree-photos-vectors%2F3d-wallpaper&docid=m7OpOqkGrqw0IM&tbnid=XV01SKEeY5qrkM&vet=12ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECFsQAA..i&w=626&h=358&hcb=2&ved=2ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECFsQAA" },
                    { new Guid("a102235e-04f6-489b-bc45-27b6e0a36387"), "BOP", "bay Of Plenty", null },
                    { new Guid("cdd6fb31-8e2f-4bb9-a3ab-544178efd622"), "NSN", "Nelson", "https://www.google.com/imgres?q=3d%20images%20hd&imgurl=https%3A%2F%2Fc4.wallpaperflare.com%2Fwallpaper%2F93%2F298%2F371%2Fsteampunk-3d-artwork-eyes-wallpaper-preview.jpg&imgrefurl=https%3A%2F%2Fwww.wallpaperflare.com%2Fsearch%3Fwallpaper%3D3d%2Bart&docid=Nx3ImR4lAPHgUM&tbnid=p85aC4PAqYTWgM&vet=12ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECFgQAA..i&w=728&h=410&hcb=2&ved=2ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECFgQAA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("2cc0f7e6-7916-47fc-902d-3892666ecfa4"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("529e8a1e-eb80-451a-a5a4-5a9a89f88350"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("fe58ef6d-3957-42bd-84eb-fb5984250b98"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3b0fe77b-2431-4471-a813-3ed206b78e8f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5199f117-ad9f-469f-91c8-3311b9b1f84d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5c237922-5fdc-4789-ae75-e2eadaa8269b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("69c60c7a-cd16-4b36-bc2f-3fba45f02e89"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a102235e-04f6-489b-bc45-27b6e0a36387"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cdd6fb31-8e2f-4bb9-a3ab-544178efd622"));
        }
    }
}
