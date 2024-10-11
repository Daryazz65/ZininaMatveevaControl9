using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZininaMatveevaControl9.Model;

namespace ZininaMatveevaControl9
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static LagerZininaMatveevaEntities1 context = new LagerZininaMatveevaEntities1();
        public static LagerZininaMatveevaEntities1 GetContext()
        {
            if( context == null)
            {
                context = new LagerZininaMatveevaEntities1();
                return context;
            }
            else
            {
                return context;
            }
        }
    }
}
