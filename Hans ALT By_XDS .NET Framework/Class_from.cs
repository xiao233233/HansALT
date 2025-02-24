using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hans_ALT_By_XDS.NET_Framework
{
    internal class Class_from
    {

        public static FormMotion formMotion;

        /// <summary>
        /// 检查窗体是否已经被创建,如果创建了就激活并返回true formName 可使用typeof(窗体的类名).Name获取
        /// </summary>
        /// <param name="formName">被检查的窗体 可使用typeof(窗体的类名).Name</param>
        /// <returns>已存在返回true，不存在返回false</returns>
        public static bool CheckForm(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    form.Activate();//如果已经存在就显示在最前面
                    return true;
                }
            }
            return false;
        }
    }
}
