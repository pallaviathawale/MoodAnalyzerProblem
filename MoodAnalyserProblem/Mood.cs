﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class Mood
    {
        string message;
        public Mood(string Message)
        {
            this.message = Message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.Exception_Type.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                else if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.Exception_Type.NULL_EXCEPTION, "Mood should not be NULL");
            }
        }
    }
}
