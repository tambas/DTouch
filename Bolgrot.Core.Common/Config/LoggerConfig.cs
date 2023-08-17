﻿using System;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Bolgrot.Core.Common.Config
{
    public class LoggerConfig
    {
        public static LoggingConfiguration GetConfig()
        {
            var config = new NLog.Config.LoggingConfiguration();
            
            //Targets where to log to: File and Console

            var logfile = new NLog.Targets.FileTarget("logfile") {FileName = $"log/{DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString()}.txt"};
            var consoleTarget = new ColoredConsoleTarget();
            consoleTarget.Layout = "${date:format=HH\\:mm\\:ss} | ${callsite:className=true:includeNamespace=false:fileName=false:includeSourcePath=false:methodName=true} | [${level:uppercase=true}] : ${message}"; 

            var highlightRule = new ConsoleRowHighlightingRule();
            
            consoleTarget.WordHighlightingRules.Add(new ConsoleWordHighlightingRule("[INFO]", ConsoleOutputColor.DarkBlue, ConsoleOutputColor.NoChange));
            consoleTarget.WordHighlightingRules.Add(new ConsoleWordHighlightingRule("[Send]", ConsoleOutputColor.DarkMagenta, ConsoleOutputColor.NoChange));
            consoleTarget.WordHighlightingRules.Add(new ConsoleWordHighlightingRule("[Receive]", ConsoleOutputColor.DarkCyan, ConsoleOutputColor.NoChange));
            consoleTarget.WordHighlightingRules.Add(new ConsoleWordHighlightingRule("[DEBUG]", ConsoleOutputColor.DarkGreen, ConsoleOutputColor.NoChange));
            consoleTarget.WordHighlightingRules.Add(new ConsoleWordHighlightingRule("[ERROR]", ConsoleOutputColor.DarkRed, ConsoleOutputColor.NoChange));
            
            //Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, consoleTarget);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            return config;
        }
    }
}