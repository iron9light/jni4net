﻿#region Copyright (C) 2012 by Pavel Savara

/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services
{
    public class Logger : ILogger
    {
        public void LogMessage(string message, IMType model = null)
        {
            Console.WriteLine(message);
        }

        public void LogError(string message, Exception ex = null, IMType model = null)
        {
            try
            {
                if (model != null)
                {
                    if(ex!=null)
                    {
                        LogMessage(message + " " + model.ToString() + ": " + ex.GetType() + " " + ex.Message, model);
                    }
                    else
                    {
                        LogMessage(message + " " + model.ToString(), model);
                    }
                }
                else
                {
                    if (ex != null)
                    {
                        LogMessage(message + ": " + ex.GetType() + " " + ex.Message, null);
                    }
                    else
                    {
                        LogMessage(message, null);
                    }
                }
            }
            catch(Exception)
            {
                LogMessage(message + ": " + ex.GetType() + " " + ex.Message, null);
            }
            LogVerbose(ex.ToString(), model);
        }

        public void LogVerbose(string message, IMType model = null)
        {
            bool verboseModel = (model!=null && model.IsVerbose);
            if (Verbose || verboseModel)
            {
                Console.WriteLine(message);
            }
        }

        public bool Verbose { get; set; }
    }
}