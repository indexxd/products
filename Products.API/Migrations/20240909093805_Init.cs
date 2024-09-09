using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUri", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://example.com/images/product1.jpg", "Bike", 111.63m },
                    { 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://example.com/images/product2.jpg", "Cheese", 404.76m },
                    { 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://example.com/images/product3.jpg", "Gloves", 697.88m },
                    { 4, "The Football Is Good For Training And Recreational Purposes", "https://example.com/images/product4.jpg", "Bacon", 991.01m },
                    { 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://example.com/images/product5.jpg", "Pants", 285.13m },
                    { 6, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://example.com/images/product6.jpg", "Pizza", 578.26m },
                    { 7, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://example.com/images/product7.jpg", "Shirt", 871.38m },
                    { 8, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://example.com/images/product8.jpg", "Salad", 165.51m },
                    { 9, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://example.com/images/product9.jpg", "Table", 458.63m },
                    { 10, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://example.com/images/product10.jpg", "Sausages", 751.76m },
                    { 11, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://example.com/images/product11.jpg", "Shoes", 45.89m },
                    { 12, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://example.com/images/product12.jpg", "Chips", 339.01m },
                    { 13, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://example.com/images/product13.jpg", "Hat", 632.14m },
                    { 14, "The Football Is Good For Training And Recreational Purposes", "https://example.com/images/product14.jpg", "Chair", 925.26m },
                    { 15, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://example.com/images/product15.jpg", "Towels", 219.39m },
                    { 16, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://example.com/images/product16.jpg", "Computer", 512.51m },
                    { 17, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://example.com/images/product17.jpg", "Soap", 805.64m },
                    { 18, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://example.com/images/product18.jpg", "Keyboard", 99.76m },
                    { 19, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://example.com/images/product19.jpg", "Tuna", 392.89m },
                    { 20, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://example.com/images/product20.jpg", "Mouse", 686.01m },
                    { 21, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://example.com/images/product21.jpg", "Chicken", 979.14m },
                    { 22, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://example.com/images/product22.jpg", "Bike", 273.26m },
                    { 23, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://example.com/images/product23.jpg", "Fish", 566.39m },
                    { 24, "The Football Is Good For Training And Recreational Purposes", "https://example.com/images/product24.jpg", "Ball", 859.51m },
                    { 25, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://example.com/images/product25.jpg", "Cheese", 153.64m },
                    { 26, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://example.com/images/product26.jpg", "Gloves", 446.76m },
                    { 27, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://example.com/images/product27.jpg", "Bacon", 739.89m },
                    { 28, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://example.com/images/product28.jpg", "Pants", 34.01m },
                    { 29, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://example.com/images/product29.jpg", "Salad", 327.14m },
                    { 30, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://example.com/images/product30.jpg", "Shirt", 620.26m },
                    { 31, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://example.com/images/product31.jpg", "Sausages", 913.39m },
                    { 32, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://example.com/images/product32.jpg", "Table", 207.51m },
                    { 33, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://example.com/images/product33.jpg", "Chips", 500.64m },
                    { 34, "The Football Is Good For Training And Recreational Purposes", "https://example.com/images/product34.jpg", "Shoes", 793.76m },
                    { 35, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://example.com/images/product35.jpg", "Chair", 87.89m },
                    { 36, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://example.com/images/product36.jpg", "Hat", 381.02m },
                    { 37, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://example.com/images/product37.jpg", "Car", 674.14m },
                    { 38, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://example.com/images/product38.jpg", "Towels", 967.27m },
                    { 39, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://example.com/images/product39.jpg", "Computer", 261.39m },
                    { 40, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://example.com/images/product40.jpg", "Soap", 554.52m },
                    { 41, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://example.com/images/product41.jpg", "Keyboard", 847.64m },
                    { 42, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://example.com/images/product42.jpg", "Chicken", 141.77m },
                    { 43, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://example.com/images/product43.jpg", "Mouse", 434.89m },
                    { 44, "The Football Is Good For Training And Recreational Purposes", "https://example.com/images/product44.jpg", "Fish", 728.02m },
                    { 45, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://example.com/images/product45.jpg", "Bike", 22.14m },
                    { 46, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://example.com/images/product46.jpg", "Cheese", 315.27m },
                    { 47, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://example.com/images/product47.jpg", "Ball", 608.39m },
                    { 48, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://example.com/images/product48.jpg", "Bacon", 901.52m },
                    { 49, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://example.com/images/product49.jpg", "Gloves", 195.64m },
                    { 50, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://example.com/images/product50.jpg", "Pizza", 488.77m },
                    { 51, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://example.com/images/product51.jpg", "Pants", 781.89m },
                    { 52, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://example.com/images/product52.jpg", "Salad", 76.02m },
                    { 53, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://example.com/images/product53.jpg", "Shirt", 369.14m },
                    { 54, "The Football Is Good For Training And Recreational Purposes", "https://example.com/images/product54.jpg", "Sausages", 662.27m },
                    { 55, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://example.com/images/product55.jpg", "Shoes", 955.39m },
                    { 56, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://example.com/images/product56.jpg", "Chips", 249.52m },
                    { 57, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://example.com/images/product57.jpg", "Hat", 542.64m },
                    { 58, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://example.com/images/product58.jpg", "Chair", 835.77m },
                    { 59, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://example.com/images/product59.jpg", "Towels", 129.89m },
                    { 60, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://example.com/images/product60.jpg", "Car", 423.02m },
                    { 61, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://example.com/images/product61.jpg", "Soap", 716.15m },
                    { 62, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://example.com/images/product62.jpg", "Computer", 10.27m },
                    { 63, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://example.com/images/product63.jpg", "Tuna", 303.40m },
                    { 64, "The Football Is Good For Training And Recreational Purposes", "https://example.com/images/product64.jpg", "Keyboard", 596.52m },
                    { 65, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://example.com/images/product65.jpg", "Chicken", 889.65m },
                    { 66, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://example.com/images/product66.jpg", "Mouse", 183.77m },
                    { 67, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://example.com/images/product67.jpg", "Fish", 476.90m },
                    { 68, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://example.com/images/product68.jpg", "Ball", 770.02m },
                    { 69, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://example.com/images/product69.jpg", "Cheese", 64.15m },
                    { 70, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://example.com/images/product70.jpg", "Gloves", 357.27m },
                    { 71, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://example.com/images/product71.jpg", "Bacon", 650.40m },
                    { 72, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://example.com/images/product72.jpg", "Pants", 943.52m },
                    { 73, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://example.com/images/product73.jpg", "Pizza", 237.65m },
                    { 74, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://example.com/images/product74.jpg", "Shirt", 530.77m },
                    { 75, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://example.com/images/product75.jpg", "Salad", 823.90m },
                    { 76, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://example.com/images/product76.jpg", "Table", 118.02m },
                    { 77, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://example.com/images/product77.jpg", "Sausages", 411.15m },
                    { 78, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://example.com/images/product78.jpg", "Shoes", 704.27m },
                    { 79, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://example.com/images/product79.jpg", "Chips", 997.40m },
                    { 80, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://example.com/images/product80.jpg", "Hat", 291.52m },
                    { 81, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://example.com/images/product81.jpg", "Car", 584.65m },
                    { 82, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://example.com/images/product82.jpg", "Towels", 877.77m },
                    { 83, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://example.com/images/product83.jpg", "Computer", 171.90m },
                    { 84, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://example.com/images/product84.jpg", "Soap", 465.02m },
                    { 85, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://example.com/images/product85.jpg", "Keyboard", 758.15m },
                    { 86, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://example.com/images/product86.jpg", "Tuna", 52.28m },
                    { 87, "The Football Is Good For Training And Recreational Purposes", "https://example.com/images/product87.jpg", "Mouse", 345.40m },
                    { 88, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://example.com/images/product88.jpg", "Chicken", 638.53m },
                    { 89, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://example.com/images/product89.jpg", "Bike", 931.65m },
                    { 90, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://example.com/images/product90.jpg", "Fish", 225.78m },
                    { 91, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://example.com/images/product91.jpg", "Ball", 518.90m },
                    { 92, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://example.com/images/product92.jpg", "Cheese", 812.03m },
                    { 93, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://example.com/images/product93.jpg", "Gloves", 106.15m },
                    { 94, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://example.com/images/product94.jpg", "Pizza", 399.28m },
                    { 95, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://example.com/images/product95.jpg", "Pants", 692.40m },
                    { 96, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://example.com/images/product96.jpg", "Salad", 985.53m },
                    { 97, "The Football Is Good For Training And Recreational Purposes", "https://example.com/images/product97.jpg", "Shirt", 279.65m },
                    { 98, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://example.com/images/product98.jpg", "Sausages", 572.78m },
                    { 99, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://example.com/images/product99.jpg", "Table", 865.90m },
                    { 100, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://example.com/images/product100.jpg", "Chips", 160.03m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
