using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    /// <summary>
    /// 基类:形状类
    /// </summary>
    class Shape
    {
        /// <summary>
        /// 颜色
        /// </summary>
       protected string Color;


        /// <summary>
        /// 形状的构造方法,初始化颜色值
        /// </summary>
        /// <param name="Color">颜色</param>
        public Shape(string Color)
        {
            this.Color = Color;
        }

        /// <summary>
        /// 无参的构造函数
        /// </summary>
        public Shape()
        {

        }

        /// <summary>
        /// 取颜色值
        /// </summary>
        /// <returns>返回颜色</returns>
        protected string Getcolor()
        {
            return Color;
        }
    }
}
