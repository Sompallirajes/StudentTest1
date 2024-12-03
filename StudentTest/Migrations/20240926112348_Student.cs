using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentTest.Migrations
{
    /// <inheritdoc />
    public partial class Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Explanation", "QuestionText" },
                values: new object[,]
                {
                    { 1, "The 'char' keyword is used to declare a character in C#.", "Which of the following is the correct syntax for declaring a character in C#?" },
                    { 2, "int is a value type in C#, while string is a reference type.", "Which of the following is a value type in C#?" },
                    { 3, "The '+' operator is used to concatenate strings in C#.", "Which operator is used for concatenation in C#?" },
                    { 4, "The default value of a Boolean variable is 'false' in C#.", "What is the default value of a Boolean in C#?" },
                    { 5, "The 'static' keyword means that a member belongs to the type itself rather than to a specific object.", "What does the keyword 'static' mean in C#?" },
                    { 6, "The 'try' keyword is used to start an exception handling block in C#.", "Which keyword is used to handle exceptions in C#?" },
                    { 7, "The 'Console.WriteLine()' method outputs a line of text to the console.", "Which method is used to output a line of text to the console in C#?" },
                    { 8, "An 'int' in C# is 32-bits, which is 4 bytes.", "What is the size of an int in C#?" },
                    { 9, "Boxing is the process of converting a value type to an object type in C#.", "What is boxing in C#?" },
                    { 10, "'System.Object' is the base class of all classes in C#.", "What is the base class of all classes in C#?" },
                    { 11, "An interface defines a contract that implementing classes must follow in C#.", "What is an interface in C#?" },
                    { 12, "'sealed' types cannot be inherited in C#.", "Which of the following types in C# does not allow for inheritance?" },
                    { 13, "Polymorphism allows methods to have different implementations depending on the object calling them.", "What is polymorphism in C#?" },
                    { 14, "The 'void' keyword indicates that the method does not return any value.", "What does the keyword 'void' indicate in a method declaration?" },
                    { 15, "String is a reference type in C#.", "Which of the following is a reference type in C#?" },
                    { 16, "'readonly' variables can only be assigned values during declaration or in the constructor.", "What is the purpose of the 'readonly' keyword in C#?" },
                    { 17, "The maximum value of an 'int' in C# is 2,147,483,647.", "What is the maximum value of an int in C#?" },
                    { 18, "The result is 11 due to operator precedence (multiplication before addition).", "What is the result of the expression '3 + 4 * 2' in C#?" },
                    { 19, "'do...while' loops are guaranteed to execute at least once.", "Which of the following loops in C# is guaranteed to execute at least once?" },
                    { 20, "The 'private' access modifier restricts access to the class in which the member is defined.", "Which access modifier in C# allows a class member to be accessible only within its own class?" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerText", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, "char", true, 1 },
                    { 2, "string", false, 1 },
                    { 3, "bool", false, 1 },
                    { 4, "int", false, 1 },
                    { 5, "int", true, 2 },
                    { 6, "string", false, 2 },
                    { 7, "bool", false, 2 },
                    { 8, "decimal", false, 2 },
                    { 9, "+", true, 3 },
                    { 10, "&", false, 3 },
                    { 11, "!", false, 3 },
                    { 12, "-", false, 3 },
                    { 13, "false", true, 4 },
                    { 14, "true", false, 4 },
                    { 15, "null", false, 4 },
                    { 16, "0", false, 4 },
                    { 17, "It belongs to the class, not the instance", true, 5 },
                    { 18, "It is inherited", false, 5 },
                    { 19, "It is abstract", false, 5 },
                    { 20, "It is readonly", false, 5 },
                    { 21, "The 'try' keyword is used to start an exception handling block in C#", true, 6 },
                    { 23, "It is inherited", false, 6 },
                    { 24, "It is abstract", false, 6 },
                    { 25, "It is readonly", false, 6 },
                    { 26, "Console.WriteLine()", true, 7 },
                    { 27, "Console.Output()", false, 7 },
                    { 28, "Console.PrintLine()", false, 7 },
                    { 29, "System.Console()", false, 7 },
                    { 30, "4 bytes", true, 8 },
                    { 31, "8 bytes", false, 8 },
                    { 32, "2 bytes", false, 8 },
                    { 33, "16 bytes", false, 8 },
                    { 34, "Converting a value type to an object type", true, 9 },
                    { 35, "Converting a reference type to a value type", false, 9 },
                    { 36, "Converting an int to a string", false, 9 },
                    { 37, "Converting an object type to a value type", false, 9 },
                    { 38, "System.Object", true, 10 },
                    { 39, "System.Base", false, 10 },
                    { 40, "System.Class", false, 10 },
                    { 41, "System.Root", false, 10 },
                    { 42, "A contract that classes must implement", true, 11 },
                    { 43, "A class with only static methods", false, 11 },
                    { 44, "A sealed class", false, 11 },
                    { 45, "A method that cannot return a value", false, 11 },
                    { 46, "Sealed", true, 12 },
                    { 47, "Abstract", false, 12 },
                    { 48, "Virtual", false, 12 },
                    { 49, "Static", false, 12 },
                    { 50, "The ability of a method to have different implementations", true, 13 },
                    { 51, "The ability to inherit from multiple classes", false, 13 },
                    { 52, "The ability of a class to have multiple constructors", false, 13 },
                    { 53, "The ability to overload operators", false, 13 },
                    { 54, "The method does not return a value", true, 14 },
                    { 55, "The method returns an integer", false, 14 },
                    { 56, "The method can return any type", false, 14 },
                    { 57, "The method is static", false, 14 },
                    { 58, "String", true, 15 },
                    { 59, "Int", false, 15 },
                    { 60, "Char", false, 15 },
                    { 61, "Float", false, 15 },
                    { 62, "It makes a variable assignable only in declaration or constructor", true, 16 },
                    { 63, "It prevents the variable from being assigned a value", false, 16 },
                    { 64, "It makes a variable accessible only within its class", false, 16 },
                    { 65, "It allows the variable to be modified from anywhere", false, 16 },
                    { 66, "2,147,483,647", true, 17 },
                    { 67, "9,223,372,036,854,775,807", false, 17 },
                    { 68, "32,767", false, 17 },
                    { 69, "65,535", false, 17 },
                    { 70, "11", true, 18 },
                    { 71, "14", false, 18 },
                    { 72, "7", false, 18 },
                    { 73, "10", false, 18 },
                    { 74, "do...while", true, 19 },
                    { 75, "while", false, 19 },
                    { 76, "for", false, 19 },
                    { 77, "foreach", false, 19 },
                    { 78, "private", true, 20 },
                    { 79, "public", false, 20 },
                    { 80, "protected", false, 20 },
                    { 81, "internal", false, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserLogins");
        }
    }
}
