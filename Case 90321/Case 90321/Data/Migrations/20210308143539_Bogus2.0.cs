using Microsoft.EntityFrameworkCore.Migrations;

namespace Case_90321.Data.Migrations
{
    public partial class Bogus20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClothingTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Licensed" },
                    { 2, "Ergonomic" },
                    { 3, "Generic" },
                    { 4, "Intelligent" },
                    { 5, "Handmade" },
                    { 6, "Fantastic" },
                    { 7, "Rustic" },
                    { 8, "Tasty" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClothingTypeId", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, "Practical Frozen Keyboard" },
                    { 155, 6, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Handmade Concrete Tuna" },
                    { 156, 6, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Incredible Metal Bacon" },
                    { 157, 6, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Tasty Granite Tuna" },
                    { 158, 6, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Licensed Fresh Pants" },
                    { 159, 6, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, "Sleek Soft Hat" },
                    { 160, 6, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 0, "Rustic Metal Sausages" },
                    { 161, 6, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, "Rustic Frozen Mouse" },
                    { 162, 6, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, "Sleek Fresh Tuna" },
                    { 163, 6, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, "Refined Granite Computer" },
                    { 164, 6, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Tasty Cotton Ball" },
                    { 165, 6, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, "Small Granite Chair" },
                    { 166, 6, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Tasty Soft Shoes" },
                    { 154, 6, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Licensed Fresh Bacon" },
                    { 167, 6, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, "Handcrafted Soft Shoes" },
                    { 169, 6, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Unbranded Concrete Mouse" },
                    { 170, 6, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Small Metal Keyboard" },
                    { 171, 6, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, "Handmade Cotton Gloves" },
                    { 172, 6, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, "Generic Frozen Shoes" },
                    { 173, 6, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Handmade Cotton Sausages" },
                    { 174, 6, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, "Ergonomic Steel Chair" },
                    { 175, 6, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, "Handcrafted Wooden Chicken" },
                    { 176, 6, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Licensed Plastic Chicken" },
                    { 177, 6, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, "Incredible Rubber Mouse" },
                    { 178, 6, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Gorgeous Cotton Hat" },
                    { 179, 6, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Ergonomic Soft Ball" },
                    { 180, 6, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Practical Concrete Fish" },
                    { 168, 6, "The Football Is Good For Training And Recreational Purposes", 0, "Small Plastic Ball" },
                    { 153, 6, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Practical Wooden Soap" },
                    { 152, 6, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, "Sleek Plastic Table" },
                    { 151, 6, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, "Handmade Rubber Hat" },
                    { 124, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, "Incredible Granite Bacon" },
                    { 125, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, "Generic Wooden Table" },
                    { 126, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Small Steel Table" },
                    { 127, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Gorgeous Steel Bike" },
                    { 128, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Rustic Soft Hat" },
                    { 129, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, "Gorgeous Cotton Ball" },
                    { 130, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, "Handmade Fresh Gloves" },
                    { 131, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, "Awesome Rubber Sausages" },
                    { 132, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Generic Wooden Hat" },
                    { 133, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Practical Concrete Chips" },
                    { 134, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, "Generic Granite Shirt" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClothingTypeId", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { 135, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Generic Frozen Chips" },
                    { 136, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, "Intelligent Fresh Tuna" },
                    { 137, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, "Rustic Metal Shoes" },
                    { 138, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Handmade Wooden Ball" },
                    { 139, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, "Tasty Concrete Shirt" },
                    { 140, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Small Cotton Shoes" },
                    { 141, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Gorgeous Granite Table" },
                    { 142, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Awesome Rubber Hat" },
                    { 143, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Handmade Granite Keyboard" },
                    { 144, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Handmade Soft Sausages" },
                    { 145, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, "Sleek Wooden Tuna" },
                    { 146, 6, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Handmade Steel Sausages" },
                    { 147, 6, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Incredible Plastic Shoes" },
                    { 148, 6, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Refined Concrete Shoes" },
                    { 149, 6, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, "Gorgeous Plastic Bike" },
                    { 150, 6, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, "Small Soft Soap" },
                    { 181, 6, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Tasty Rubber Mouse" },
                    { 123, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, "Handcrafted Metal Bacon" },
                    { 182, 6, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, "Awesome Metal Salad" },
                    { 184, 7, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, "Practical Cotton Soap" },
                    { 216, 8, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Small Granite Hat" },
                    { 217, 8, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, "Handmade Cotton Sausages" },
                    { 218, 8, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, "Gorgeous Wooden Cheese" },
                    { 219, 8, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, "Awesome Plastic Towels" },
                    { 220, 8, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 0, "Small Frozen Bike" },
                    { 221, 8, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Licensed Rubber Mouse" },
                    { 222, 8, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Refined Metal Hat" },
                    { 223, 8, "The Football Is Good For Training And Recreational Purposes", 3, "Awesome Steel Ball" },
                    { 224, 8, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Handmade Wooden Pizza" },
                    { 225, 8, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, "Gorgeous Soft Bacon" },
                    { 226, 8, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, "Practical Steel Gloves" },
                    { 227, 8, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Small Plastic Mouse" },
                    { 215, 8, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 0, "Handmade Rubber Gloves" },
                    { 228, 8, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Rustic Concrete Shoes" },
                    { 230, 8, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, "Awesome Steel Chair" },
                    { 231, 8, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Unbranded Wooden Salad" },
                    { 232, 8, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, "Tasty Soft Keyboard" },
                    { 233, 8, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Refined Plastic Hat" },
                    { 234, 8, "The Football Is Good For Training And Recreational Purposes", 2, "Gorgeous Fresh Table" },
                    { 235, 8, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Sleek Rubber Pizza" },
                    { 236, 8, "The Football Is Good For Training And Recreational Purposes", 1, "Handcrafted Fresh Towels" },
                    { 237, 8, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, "Practical Frozen Computer" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClothingTypeId", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { 238, 8, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, "Tasty Cotton Pizza" },
                    { 239, 8, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, "Fantastic Wooden Chair" },
                    { 240, 8, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Intelligent Steel Gloves" },
                    { 241, 8, "The Football Is Good For Training And Recreational Purposes", 2, "Handcrafted Rubber Shoes" },
                    { 229, 8, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Awesome Rubber Sausages" },
                    { 214, 8, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Fantastic Rubber Chair" },
                    { 213, 8, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, "Rustic Steel Towels" },
                    { 212, 8, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, "Ergonomic Granite Computer" },
                    { 185, 7, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Rustic Wooden Bacon" },
                    { 186, 7, "The Football Is Good For Training And Recreational Purposes", 2, "Unbranded Frozen Chair" },
                    { 187, 7, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, "Intelligent Frozen Shirt" },
                    { 188, 7, "The Football Is Good For Training And Recreational Purposes", 1, "Licensed Frozen Shoes" },
                    { 189, 7, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, "Small Cotton Hat" },
                    { 190, 7, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, "Generic Plastic Ball" },
                    { 191, 7, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, "Incredible Fresh Computer" },
                    { 192, 7, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Small Rubber Chicken" },
                    { 193, 7, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, "Tasty Cotton Pizza" },
                    { 194, 7, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Licensed Concrete Bacon" },
                    { 195, 7, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, "Sleek Frozen Car" },
                    { 196, 7, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, "Handmade Rubber Chair" },
                    { 197, 7, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, "Generic Metal Bacon" },
                    { 198, 7, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, "Incredible Fresh Chips" },
                    { 199, 7, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, "Gorgeous Concrete Bacon" },
                    { 200, 7, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Generic Rubber Pizza" },
                    { 201, 7, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Fantastic Granite Hat" },
                    { 202, 7, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, "Practical Fresh Pizza" },
                    { 203, 7, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, "Practical Rubber Salad" },
                    { 204, 7, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Gorgeous Rubber Keyboard" },
                    { 205, 7, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, "Unbranded Plastic Towels" },
                    { 206, 7, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Intelligent Wooden Gloves" },
                    { 207, 7, "The Football Is Good For Training And Recreational Purposes", 3, "Rustic Soft Ball" },
                    { 208, 7, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, "Rustic Wooden Car" },
                    { 209, 7, "The Football Is Good For Training And Recreational Purposes", 3, "Sleek Steel Car" },
                    { 210, 7, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Handcrafted Cotton Pants" },
                    { 211, 8, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, "Practical Frozen Shirt" },
                    { 183, 6, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Gorgeous Concrete Fish" },
                    { 242, 8, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 0, "Incredible Concrete Computer" },
                    { 122, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Sleek Metal Shoes" },
                    { 120, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, "Ergonomic Cotton Mouse" },
                    { 33, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, "Sleek Concrete Table" },
                    { 34, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Handmade Frozen Bacon" },
                    { 35, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Rustic Rubber Computer" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClothingTypeId", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { 36, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Tasty Cotton Shirt" },
                    { 37, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Awesome Steel Salad" },
                    { 38, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, "Tasty Cotton Chair" },
                    { 39, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Intelligent Steel Chicken" },
                    { 40, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Practical Metal Soap" },
                    { 41, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, "Incredible Cotton Table" },
                    { 42, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Small Wooden Chair" },
                    { 43, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, "Practical Cotton Car" },
                    { 44, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Small Frozen Chicken" },
                    { 32, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Unbranded Plastic Cheese" },
                    { 45, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, "Awesome Metal Salad" },
                    { 47, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Handcrafted Metal Cheese" },
                    { 48, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, "Sleek Steel Salad" },
                    { 49, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Refined Concrete Chips" },
                    { 50, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, "Gorgeous Frozen Car" },
                    { 51, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Sleek Steel Gloves" },
                    { 52, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, "Generic Granite Pants" },
                    { 53, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, "Sleek Soft Keyboard" },
                    { 54, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Handmade Metal Cheese" },
                    { 55, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, "Small Wooden Shirt" },
                    { 56, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Incredible Soft Towels" },
                    { 57, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, "Ergonomic Granite Tuna" },
                    { 58, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, "Generic Cotton Tuna" },
                    { 46, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Ergonomic Granite Shirt" },
                    { 31, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Incredible Soft Car" },
                    { 30, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Small Steel Shoes" },
                    { 29, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Incredible Granite Keyboard" },
                    { 2, 1, "The Football Is Good For Training And Recreational Purposes", 3, "Gorgeous Plastic Cheese" },
                    { 3, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Gorgeous Rubber Table" },
                    { 4, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, "Sleek Granite Salad" },
                    { 5, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Licensed Metal Bike" },
                    { 6, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, "Incredible Steel Fish" },
                    { 7, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Rustic Fresh Ball" },
                    { 8, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Fantastic Soft Car" },
                    { 9, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, "Practical Cotton Computer" },
                    { 10, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, "Refined Soft Cheese" },
                    { 11, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Sleek Wooden Sausages" },
                    { 12, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Licensed Metal Chicken" },
                    { 13, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, "Intelligent Rubber Cheese" },
                    { 14, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Fantastic Plastic Chicken" },
                    { 15, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Handmade Cotton Hat" },
                    { 16, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Fantastic Rubber Car" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClothingTypeId", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { 17, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, "Generic Concrete Computer" },
                    { 18, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, "Tasty Frozen Cheese" },
                    { 19, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Handcrafted Wooden Salad" },
                    { 20, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Refined Rubber Car" },
                    { 21, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, "Practical Steel Table" },
                    { 22, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Small Metal Table" },
                    { 23, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Gorgeous Rubber Chair" },
                    { 24, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, "Tasty Granite Bacon" },
                    { 25, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Practical Rubber Bacon" },
                    { 26, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, "Handcrafted Granite Shirt" },
                    { 27, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, "Licensed Granite Tuna" },
                    { 28, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Sleek Fresh Sausages" },
                    { 59, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Small Metal Chair" },
                    { 121, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, "Handmade Rubber Hat" },
                    { 60, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, "Small Steel Hat" },
                    { 62, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Fantastic Steel Pants" },
                    { 94, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, "Licensed Plastic Computer" },
                    { 95, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Sleek Steel Tuna" },
                    { 96, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, "Gorgeous Plastic Pants" },
                    { 97, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Generic Steel Chair" },
                    { 98, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Tasty Wooden Sausages" },
                    { 99, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Handmade Frozen Keyboard" },
                    { 100, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, "Unbranded Cotton Chicken" },
                    { 101, 4, "The Football Is Good For Training And Recreational Purposes", 0, "Practical Metal Bacon" },
                    { 102, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Generic Cotton Chicken" },
                    { 103, 4, "The Football Is Good For Training And Recreational Purposes", 3, "Rustic Granite Keyboard" },
                    { 104, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Sleek Cotton Chips" },
                    { 105, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, "Handcrafted Cotton Gloves" },
                    { 93, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, "Awesome Cotton Ball" },
                    { 106, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Awesome Fresh Bike" },
                    { 108, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, "Unbranded Concrete Table" },
                    { 109, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, "Awesome Cotton Chicken" },
                    { 110, 4, "The Football Is Good For Training And Recreational Purposes", 3, "Intelligent Fresh Towels" },
                    { 111, 4, "The Football Is Good For Training And Recreational Purposes", 2, "Sleek Cotton Gloves" },
                    { 112, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, "Ergonomic Cotton Salad" },
                    { 113, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Handmade Wooden Soap" },
                    { 114, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Sleek Steel Hat" },
                    { 115, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Incredible Frozen Cheese" },
                    { 116, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, "Gorgeous Metal Tuna" },
                    { 117, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, "Handmade Concrete Computer" },
                    { 118, 5, "The Football Is Good For Training And Recreational Purposes", 1, "Unbranded Fresh Tuna" },
                    { 119, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, "Practical Metal Cheese" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClothingTypeId", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { 107, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, "Refined Rubber Table" },
                    { 92, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, "Practical Fresh Keyboard" },
                    { 91, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Handcrafted Steel Computer" },
                    { 90, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, "Licensed Soft Soap" },
                    { 63, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, "Unbranded Concrete Towels" },
                    { 64, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 0, "Gorgeous Frozen Towels" },
                    { 65, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 0, "Intelligent Rubber Bacon" },
                    { 66, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Handmade Steel Car" },
                    { 67, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, "Practical Rubber Chair" },
                    { 68, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, "Licensed Fresh Keyboard" },
                    { 69, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Generic Concrete Bike" },
                    { 70, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Licensed Wooden Bacon" },
                    { 71, 3, "The Football Is Good For Training And Recreational Purposes", 0, "Awesome Granite Hat" },
                    { 72, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Handcrafted Steel Tuna" },
                    { 73, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Incredible Frozen Computer" },
                    { 74, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, "Incredible Concrete Fish" },
                    { 75, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Practical Soft Towels" },
                    { 76, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Tasty Cotton Chicken" },
                    { 77, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Generic Concrete Keyboard" },
                    { 78, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Unbranded Steel Table" },
                    { 79, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Handcrafted Concrete Bacon" },
                    { 80, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Generic Wooden Soap" },
                    { 81, 3, "The Football Is Good For Training And Recreational Purposes", 1, "Awesome Cotton Sausages" },
                    { 82, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, "Handmade Frozen Mouse" },
                    { 83, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Gorgeous Cotton Chair" },
                    { 84, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, "Ergonomic Fresh Soap" },
                    { 85, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Gorgeous Soft Sausages" },
                    { 86, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Intelligent Frozen Table" },
                    { 87, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, "Licensed Soft Chair" },
                    { 88, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, "Generic Wooden Salad" },
                    { 89, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Gorgeous Metal Keyboard" },
                    { 61, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Incredible Fresh Chair" },
                    { 243, 8, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, "Rustic Concrete Soap" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ClothingTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClothingTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClothingTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClothingTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClothingTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClothingTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClothingTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClothingTypes",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
