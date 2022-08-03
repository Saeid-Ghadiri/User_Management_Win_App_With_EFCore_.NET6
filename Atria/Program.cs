//namespace Atria
//{
//    internal static class Program
//    {
//        [STAThread]
//        static void Main()
//        {
//            ApplicationConfiguration.Initialize();
//            Application.Run(new Form1());
//        }
//    }
//}

// **************************************************

using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Atria
{
    internal static class Program : object
    {
        #region DefaultConstractor
        static Program()
        {
        }
        #endregion DefaultConstractor

        #region Main
        [System.STAThread]
        public static async System.Threading.Tasks.Task Main()
        {
            // **************************************************
            //await CreateRoleAsync();
            // **************************************************

            // **************************************************
            //await CreateUserAsync();
            // **************************************************

            // **************************************************
            //await CreateSomeUserLoginsAsync();
            // **************************************************

            //// **************************************************
            //await DeleteUserAsync();
            //// **************************************************

            // **************************************************
            // **************************************************

            // **************************************************
            //Standard Program.cs

            //ApplicationConfiguration.Initialize();
            //System.Windows.Forms.Application.Run(new Form1());
            // **************************************************

            // **************************************************
            #region Solution (2)

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            System.Windows.Forms.Application.Run(Infrastructure.Utility.LoginForm);
            //System.Windows.Forms.Application.Run(Infrastructure.Utility.SplashScreenForm);

            Infrastructure.Utility.DisposeLoginForm();
            Infrastructure.Utility.DisposeMainForm();
            //Infrastructure.Utility.DisposeRegisterForm();
            //Infrastructure.Utility.DisposeSplashScreenForm();
            //Infrastructure.Utility.DisposeMainRibbonForm();
            //Infrastructure.Utility.DisposeAboutAtriaForm();

            #endregion /Solution (2)
            // **************************************************

        }
        #endregion Main

        #region CRUD
        private static async System.Threading.Tasks.Task CreateRoleAsync()
        {
            Data.DatabaseContext? databaseContext = null;

            try
            {
                databaseContext =
                    new Data.DatabaseContext();

                var roleName = "مدیر سیستم";

                var foundedRole =
                    await
                    databaseContext.Roles
                    .Where(current => current.Name.ToLower() == roleName.ToLower())
                    .FirstOrDefaultAsync();

                if (foundedRole != null)
                {
                    System.Console.WriteLine
                        (value: $"This role [{roleName}] already exists!");

                    return;
                }

                var role =
                    new Domain.Aggregates.Roles.Role(name: roleName)
                    {
                        IsActive = true,
                    };

                var isValid =
                    Domain.SeedWork.ValidationHelper.IsValid(entity: role);

                var results =
                    Domain.SeedWork.ValidationHelper.GetValidationResults(entity: role);

                if (isValid)
                {
                    var entityEntry =
                        await
                        databaseContext.AddAsync(entity: role);

                    var affectedRows =
                        await
                        databaseContext.SaveChangesAsync();
                }
            }
            catch (System.Exception ex)
            {
                // Log Error!

                System.Console.WriteLine(value: ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    await databaseContext.DisposeAsync();
                }
            }
        }

        private static async System.Threading.Tasks.Task CreateUserAsync()
        {
            Data.DatabaseContext? databaseContext = null;

            try
            {
                databaseContext =
                    new Data.DatabaseContext();

                //var defaultRole =
                //	await
                //	databaseContext.Roles
                //	.Where(current => current.Id == Domain.Role.DefaultRoleId)
                //	.FirstOrDefaultAsync();

                //if (defaultRole == null)
                //{
                //	System.Console.WriteLine
                //		(value: $"There is not any default role!");

                //	return;
                //}

                var emailAddress =
                    "Ghadiri.Saeid@Gmail.com";

                var foundedUser =
                    await
                    databaseContext.Users
                    .Where(current => current.EmailAddress.ToLower() == emailAddress.ToLower())
                    .FirstOrDefaultAsync();

                if (foundedUser != null)
                {
                    System.Console.WriteLine
                        (value: $"This user [{emailAddress}] already exists!");

                    return;
                }

                //var user =
                //	new Domain.Aggregates.Users.User(emailAddress: emailAddress, roleId: Domain.Role.DefaultRoleId)

                var user =
                    new Domain.Aggregates.Users.User(emailAddress: emailAddress)
                    {
                        IsActive = true,
                        IsEmailAddressVerified = true,

                        CellPhoneNumber = "09126898731",

                        Password =
                            Dtat.Hashing.GetSha256(text: "123"),
                    };

                var isValid =
                    Domain.SeedWork.ValidationHelper.IsValid(entity: user);

                var results =
                    Domain.SeedWork.ValidationHelper.GetValidationResults(entity: user);

                if (isValid)
                {
                    var entityEntry =
                        await
                        databaseContext.AddAsync(entity: user);

                    var affectedRows =
                        await
                        databaseContext.SaveChangesAsync();
                }
            }
            catch (System.Exception ex)
            {
                // Log Error!

                System.Console.WriteLine(value: ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    await databaseContext.DisposeAsync();
                }
            }
        }

        private static async System.Threading.Tasks.Task CreateSomeUserLoginsAsync()
        {
            Data.DatabaseContext? databaseContext = null;

            try
            {
                databaseContext =
                    new Data.DatabaseContext();

                var emailAddress =
                    "Ghadiri.Saeid@Gmail.com";

                var foundedUser =
                    await
                    databaseContext.Users
                    .Where(current => current.EmailAddress.ToLower() == emailAddress.ToLower())
                    .FirstOrDefaultAsync();

                if (foundedUser == null)
                {
                    System.Console.WriteLine
                        (value: $"There is not such as user [{emailAddress}]!");

                    return;
                }

                for (int index = 1; index <= 5; index++)
                {
                    var usesrIP =
                        $"{index}.{index}.{index}.{index}";

                    var userLogin =
                        new Domain.Aggregates.Users.UserLogin(userId: foundedUser.Id, userIP: usesrIP);

                    var isValid =
                        Domain.SeedWork.ValidationHelper.IsValid(entity: userLogin);

                    var results =
                        Domain.SeedWork.ValidationHelper.GetValidationResults(entity: userLogin);

                    if (isValid)
                    {
                        var entityEntry =
                            await
                            databaseContext.AddAsync(entity: userLogin);

                        var affectedRows =
                            await
                            databaseContext.SaveChangesAsync();
                    }
                }
            }
            catch (System.Exception ex)
            {
                // Log Error!

                System.Console.WriteLine(value: ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    await databaseContext.DisposeAsync();
                }
            }
        }

        private static async System.Threading.Tasks.Task DeleteUserAsync()
        {
            Data.DatabaseContext? databaseContext = null;

            try
            {
                databaseContext =
                    new Data.DatabaseContext();

                var emailAddress =
                    "Ghadiri.Saeid@Gmail.com";

                var foundedUser =
                    await
                    databaseContext.Users
                    .Where(current => current.EmailAddress.ToLower() == emailAddress.ToLower())
                    .FirstOrDefaultAsync();

                if (foundedUser == null)
                {
                    System.Console.WriteLine
                        (value: $"There is not such as user [{emailAddress}]!");

                    return;
                }

                var entityEntry =
                    databaseContext.Remove(entity: foundedUser);

                var affectedRows =
                    await
                    databaseContext.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                // Log Error!

                System.Console.WriteLine(value: ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    await databaseContext.DisposeAsync();
                }
            }
        }

        #endregion CRUD
    }
}
