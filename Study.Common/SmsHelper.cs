using qcloudsms_csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Common
{
    public static class SmsHelper
    {
        // 短信应用SDK AppID
        private const int appid = 1400228490;
        // 短信应用SDK AppKey
        private const string appkey = "dad6bbb65ffda62159ff0734d96e843d";
        // 短信模板ID，需要在短信应用中申请
        private const int templateId = 369480;
        //签名
        private const string smsSign = "促联网络";
        /// <summary>
        /// 指定模板发送单条信息
        /// </summary>
        /// <param name="MsgType">短信类型</param>
        /// <param name="MsgContent">短信内容</param>
        /// <param name="phoneNumbers">发送号码</param>
        public static string SendSmsHaveTemplateForOne(SmsMsgType MsgType, string MsgContent, string[] phoneNumbers)
        {
            try
            {
                SmsSingleSender ssender = new SmsSingleSender(appid, appkey);
                var result = ssender.sendWithParam("86", phoneNumbers[0], (int)MsgType, new[] { MsgContent }, smsSign, "", "");
                return result.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 发送单条信息
        /// </summary>
        /// <param name="MsgType">短信类型</param>
        /// <param name="MsgContent">短信内容</param>
        /// <param name="phoneNumbers">发送号码</param>
        public static string SendSmsForOne(string MsgContent, string phoneNumber)
        {
            try
            {
                SmsSingleSender ssender = new SmsSingleSender(appid, appkey);
                var result = ssender.send(0, "86", phoneNumber, MsgContent, "", "");
                return result.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// 指定模板群发信息
        /// </summary>
        /// <param name="MsgType">短信类型</param>
        /// <param name="MsgContent">短信内容</param>
        /// <param name="phoneNumbers">发送号码</param>
        public static string SendSmsHaveTemplateForMore(SmsMsgType MsgType, string MsgContent, string[] phoneNumbers)
        {
            try
            {
                SmsMultiSender msender = new SmsMultiSender(appid, appkey);
                var result = msender.sendWithParam("86", phoneNumbers, templateId, new[] { MsgContent }, smsSign, "", "");
                return result.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 群发信息
        /// </summary>
        /// <param name="MsgType">短信类型</param>
        /// <param name="MsgContent">短信内容</param>
        /// <param name="phoneNumbers">发送号码</param>
        public static string SendSmsForMore(string MsgContent, string[] phoneNumbers)
        {
            try
            {
                SmsMultiSender msender = new SmsMultiSender(appid, appkey);
                var result = msender.send(0, "86", phoneNumbers, MsgContent, "", "");
                return result.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
