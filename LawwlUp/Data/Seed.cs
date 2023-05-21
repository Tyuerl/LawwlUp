using Microsoft.AspNetCore.Identity;
using LawwlUp.Data.Enums;
using LawwlUp.Models;

namespace LawwlUp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                var Test1 = new Test()
                {
                    Title = "Тест 1",
                    Description = "Правовичка Общаги",
                    CountQuestions = 5,
                    Point = 10
                };
                var Test2 = new Test()
                {
                    Title = "Тест 2",
                    Description = "Правовичка Стипендии",
                    CountQuestions = 1,
                    Point = 10
                };
                var Test3 = new Test()
                {
                    Title = "Тест 3",
                    Description = "Правовичка Профсоюз",
                    CountQuestions = 1,
                    Point = 10
                };

                if (!context.Tests.Any())
                {
                    context.Tests.AddRange(new List<Test>()
                    {
                        Test1,
                        Test2,
                        Test3,
                        new Test()
                        {
                            Title = "Тест 4",
                            Description = "Правовичка Даты",
                            CountQuestions = 1,
                            Point = 5
                         },
                    });
                    context.SaveChanges();
                }
                if (!context.Guides.Any())
                {
                    context.Guides.AddRange(new List<Guide>()
                    {
                        new Guide()
                        {
                            Title = "Приказ Минобрнауки Рф 27.12.2016 1663",
                            Description = "Что-то про закон"
                        },
                        new Guide()
                        {
                            Title = "Приказ Минобрнауки Рф 27.12.2016 1663",
                            Description = "Что-то про закон"
                        },                        
                        new Guide()
                        {
                            Title = "Приказ Минобрнауки Рф 27.12.2016 1663",
                            Description = "Что-то про закон"
                        },
                    });
                    context.SaveChanges();
                }


                //questions
                if (!context.Questions.Any())
                {
                    context.Questions.AddRange(new List<Question>()
                    {
                        new Question()
                        {
                            Title = "Сколько минимально кв. метров необходимо для проживания 3 студентов в общежитии?",
                            Answer = "18",
                            Test = Test1
                        },
                        new Question()
                        {
                            Title = "Сколько минимально кв. метров необходимо для проживания 4 студентов в общежитии?",
                            Answer = "24",
                            Test = Test1
                        },
                        new Question()
                        {
                            Title = "Сколько минимально кв. метров необходимо для проживания 2 студентов в общежитии?",
                            Answer = "16",
                            Test = Test1
                        },
                        new Question()
                        {
                            Title = "Кем подписывается закон Жк Рф",
                            Answer = "Президентом",
                            Test = Test1
                        },
                        new Question()
                        {
                            Title = "Где распологается мусоросборники",
                            Answer = "От 25 до 100 м",
                            Test = Test1
                        },
                        new Question()
                        {
                            Title = "Норматив стипендии ГСС Во",
                            Answer = "2227",
                            Test = Test2
                        },
                        new Question()
                        {
                            Title = "Скс рт",
                            Answer = "Виноградова Юлия Владимировна",
                            Test = Test3
                        },
                    });
                    context.SaveChanges();
                }
            }
        }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new AppUser()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}
    }
}