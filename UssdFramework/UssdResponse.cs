﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UssdFramework
{
    /// <summary>
    /// USSD response model.
    /// </summary>
    public class UssdResponse
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Message { get; set; }
        public string ClientState { get; set; }

        /// <summary>
        /// Generate an appropriate USSD response based on <paramref name="type"/>.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static UssdResponse Generate(UssdResponseTypes type, string message)
        {
            return new UssdResponse()
            {
                Type = type.ToString(),
                Message = message
            };
        }

        /// <summary>
        /// Generate a "Response" USSD response.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static UssdResponse Response(string message)
        {
            return Generate(UssdResponseTypes.Response, message);
        }

        /// <summary>
        /// Generate a "Release" USSD response.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static UssdResponse Release(string message)
        {
            return Generate(UssdResponseTypes.Release, message);
        }

        /// <summary>
        /// Generate a "Response" USSD response for menu.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static UssdResponse Menu(string message)
        {
            return Response(message);
        }

        /// <summary>
        /// Generate a "Response" USSD response for input.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static UssdResponse Input(string message)
        {
            return Response(message);
        }

        /// <summary>
        /// Generate a "Release" USSD response for notice.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static UssdResponse Notice(string message)
        {
            return Release(message);
        }
    }
}