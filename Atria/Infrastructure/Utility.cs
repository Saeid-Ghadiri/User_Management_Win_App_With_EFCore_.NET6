using Domain.Aggregates.Users;
using System.Linq;

//namespace Atria.Infrastructure
namespace Atria.Infrastructure
{
    public static class Utility
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        static Utility()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            // Solution (3)
            //MainForm = new Atria.Forms.MainForm();
            //LoginForm = new Atria.Forms.LoginForm();
            //RegisterForm = new Atria.Forms.RegisterForm();
            // /Solution (3)
        }

        // **************************************************
        // **************************************************
        // **************************************************
        //public static string FullName { get; set; }
        //public static string Username { get; set; }
        //public static System.Guid? UserId { get; set; }
        // **************************************************

        // **************************************************



        //public static Domain.Aggregates.Users.User AuthenticatedUser { get; set; }



        // **************************************************
        // **************************************************
        // **************************************************
        #region Solutions
        // **************************************************
        // Solution (1)
        // **************************************************
        //public static Atria.Forms.MainForm MainForm;
        //public static Atria.Forms.LoginForm LoginForm;
        //public static Atria.Forms.RegisterForm RegisterForm;
        // **************************************************
        // /Solution (1)
        // **************************************************

        // **************************************************
        // Solution (2)
        // **************************************************
        //public static Atria.Forms.MainForm MainForm = new Atria.Forms.MainForm();
        //public static Atria.Forms.LoginForm LoginForm = new Atria.Forms.LoginForm();
        //public static Atria.Forms.RegisterForm RegisterForm = new Atria.Forms.RegisterForm();
        // **************************************************
        // /Solution (2)
        // **************************************************

        // **************************************************
        // Solution (3)
        // **************************************************
        //public static Atria.Forms.MainForm MainForm;
        //public static Atria.Forms.LoginForm LoginForm;
        //public static Atria.Forms.RegisterForm RegisterForm;
        // **************************************************
        // /Solution (3)
        // **************************************************

        // **************************************************
        // Solution (4)
        // **************************************************
        // **************************************************
        // **************************************************
        private static Atria.Forms.LoginForm? _loginForm;
        // **************************************************

        // **************************************************
        /// <summary>
        /// Lazy Loading = Lazy Initialization
        /// </summary>
        public static Atria.Forms.LoginForm LoginForm
        {
            get
            {
                if (_loginForm == null || _loginForm.IsDisposed)
                {
                    _loginForm =
                        new Atria.Forms.LoginForm();
                }

                return _loginForm;
            }
        }
        // **************************************************

        // **************************************************
        public static void DisposeLoginForm()
        {
            if (_loginForm != null)
            {
                if (_loginForm.IsDisposed == false)
                {
                    _loginForm.Dispose();
                }

                _loginForm = null;
            }
        }
        // **************************************************
        // **************************************************
        // **************************************************

        //// **************************************************
        //// **************************************************
        //// **************************************************
        ////private static Atria.Forms.RegisterForm? _registerForm;
        //// **************************************************

        //// **************************************************
        ///// <summary>
        ///// Lazy Loading = Lazy Initialization
        ///// </summary>
        ////public static Atria.Forms.RegisterForm RegisterForm
        ////{
        ////    get
        ////    {
        ////        if (_registerForm == null || _registerForm.IsDisposed)
        ////        {
        ////            _registerForm =
        ////                new Atria.Forms.RegisterForm();
        ////        }

        ////        return _registerForm;
        ////    }
        ////}
        //// **************************************************

        //// **************************************************
        ////public static void DisposeRegisterForm()
        ////{
        ////    if (_registerForm != null)
        ////    {
        ////        if (_registerForm.IsDisposed == false)
        ////        {
        ////            _registerForm.Dispose();
        ////        }

        ////        _registerForm = null;
        ////    }
        ////}
        //// **************************************************
        //// **************************************************
        //// **************************************************

        // **************************************************
        // **************************************************
        // **************************************************
        private static Atria.Forms.MainForm? _mainForm;
        // **************************************************

        // **************************************************
        /// <summary>
        /// Lazy Loading = Lazy Initialization
        /// </summary>
        public static Atria.Forms.MainForm MainForm
        {
            get
            {
                if (_mainForm == null || _mainForm.IsDisposed)
                {
                    _mainForm =
                        new Atria.Forms.MainForm();
                }

                return _mainForm;
            }
        }

        public static User AuthenticatedUser { get; internal set; }

        // **************************************************

        // **************************************************
        public static void DisposeMainForm()
        {
            if (_mainForm != null)
            {
                if (_mainForm.IsDisposed == false)
                {
                    _mainForm.Dispose();
                }

                _mainForm = null;
            }
        }
        // **************************************************
        // **************************************************
        // **************************************************

        // **************************************************
        // **************************************************
        // **************************************************
        private static Atria.Forms.SplashScreenForm? _splashScreenForm;
        // **************************************************

        // **************************************************
        /// <summary>
        /// Lazy Loading = Lazy Initialization
        /// </summary>
        public static Atria.Forms.SplashScreenForm SplashScreenForm
        {
            get
            {
                if (_splashScreenForm == null || _splashScreenForm.IsDisposed)
                {
                    _splashScreenForm =
                        new Atria.Forms.SplashScreenForm();
                }

                return _splashScreenForm;
            }
        }
        // **************************************************

        // **************************************************
        public static void DisposeSplashScreenForm()
        {
            if (_splashScreenForm != null)
            {
                if (_splashScreenForm.IsDisposed == false)
                {
                    _splashScreenForm.Dispose();
                }

                _splashScreenForm = null;
            }
        }
        // **************************************************
        // **************************************************
        // **************************************************

        //// **************************************************
        //// **************************************************
        //// **************************************************
        ////private static Atria.Forms.MainRibbonForm? _mainRibbonForm;
        //// **************************************************

        //// **************************************************
        ///// <summary>
        ///// Lazy Loading = Lazy Initialization
        ///// </summary>
        ////public static Atria.Forms.MainRibbonForm MainRibbonForm
        ////{
        ////    get
        ////    {
        ////        if (_mainRibbonForm == null || _splashScreenForm.IsDisposed)
        ////        {
        ////            _mainRibbonForm =
        ////                new Atria.Forms.MainRibbonForm();
        ////        }

        ////        return _mainRibbonForm;
        ////    }
        ////}
        //// **************************************************

        //// **************************************************
        ////public static void DisposeMainRibbonForm()
        ////{
        ////    if (_mainRibbonForm != null)
        ////    {
        ////        if (_mainRibbonForm.IsDisposed == false)
        ////        {
        ////            _mainRibbonForm.Dispose();
        ////        }

        ////        _mainRibbonForm = null;
        ////    }
        ////}
        //// **************************************************
        //// **************************************************
        //// **************************************************

        //// **************************************************
        //// **************************************************
        //// **************************************************
        ////private static Atria.Forms.AboutAtriaForm? _aboutAtriaForm;
        //// **************************************************

        //// **************************************************
        ///// <summary>
        ///// Lazy Loading = Lazy Initialization
        ///// </summary>
        ////public static Atria.Forms.AboutAtriaForm AboutAtriaForm
        ////{
        ////    get
        ////    {
        ////        if (_aboutAtriaForm == null || _aboutAtriaForm.IsDisposed)
        ////        {
        ////            _aboutAtriaForm =
        ////                new Atria.Forms.AboutAtriaForm();
        ////        }

        ////        return _aboutAtriaForm;
        ////    }
        ////}
        //// **************************************************

        //// **************************************************
        ////public static void DisposeAboutAtriaForm()
        ////{
        ////    if (_aboutAtriaForm != null)
        ////    {
        ////        if (_aboutAtriaForm.IsDisposed == false)
        ////        {
        ////            _aboutAtriaForm.Dispose();
        ////        }

        ////        _aboutAtriaForm = null;
        ////    }
        ////}
        //// **************************************************
        //// **************************************************
        //// **************************************************

        //// **************************************************
        //// **************************************************
        //// **************************************************
        ////private static Atria.Forms.PhonebookForm? _phonebookForm;
        //// **************************************************

        //// **************************************************
        ///// <summary>
        ///// Lazy Loading = Lazy Initialization
        ///// </summary>
        ////public static Atria.Forms.PhonebookForm PhonebookForm
        ////{
        ////    get
        ////    {
        ////        if (_phonebookForm == null || _phonebookForm.IsDisposed)
        ////        {
        ////            _phonebookForm =
        ////                new Atria.Forms.PhonebookForm();
        ////        }

        ////        return _phonebookForm;
        ////    }
        ////}
        //// **************************************************

        //// **************************************************
        ////public static void DisposePhonebookForm()
        ////{
        ////    if (_phonebookForm != null)
        ////    {
        ////        if (_phonebookForm.IsDisposed == false)
        ////        {
        ////            _phonebookForm.Dispose();
        ////        }

        ////        _phonebookForm = null;
        ////    }
        ////}
        //// **************************************************
        //// **************************************************
        //// **************************************************

        // /Solution (4)
        // **************************************************
        #endregion Solutions

        public static string? FixText(string text)
        {
            if (text == null)
            {
                return null;
            }

            text =
                text.Trim();

            if (text == string.Empty)
            {
                return null;
            }

            // تا وقتی که در داخل متن، دو فاصله وجود دارد
            // دو فاصله را به یک فاصله تبدیل کن
            while (text.Contains("  "))
            {
                text =
                    text.Replace("  ", " ");
            }

            return text;
        }
    }
}
