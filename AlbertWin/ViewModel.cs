﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albert.Flex.Windows
{
    public abstract class ViewModel: Notify
    {


        /// <summary>
        /// Method allows the ViewModel to run other .exe on the system 
        /// </summary>
        /// <param name="exeFile">File path of the .exe file</param>
        public void RunExeFile(string exeFile)
        {
            Process p = new Process();
            p.StartInfo.FileName = exeFile;
            p.Start();
        }

		public static Action<string> VMNotify;

		//Interface values 


    }
}
