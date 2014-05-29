﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using GlobusLinkedinLib.Authentication;
using GlobusLinkedinLib.App.Core;
using System.IO;

namespace GlobusLinkedinLib.LinkedIn.Core.ShareAndSocialStreamMethods
{
    class ShareAndSocialStream
    {
        private XmlDocument xmlResult;
        public ShareAndSocialStream()
        {
            xmlResult = new XmlDocument();
         }
        /// <summary>
        /// To retrieve updates from 1st degree connections of the authenticated user
        /// </summary>
        /// <param name="OAuth"></param>
        /// <param name="LinkedInId"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public XmlDocument Get_UserUpdates(oAuthLinkedIn OAuth, string LinkedInId, int Count)
        {
            string response = OAuth.APIWebRequest("GET", Global.GetNetworkUserUpdates + LinkedInId + "/network/updates?scope=self" + "&count=" + Count, null);
            xmlResult.Load(new StringReader(response));
            return xmlResult;
        }

        /// <summary>
        /// The Get Network Updates API returns the users network updates, which is the LinkedIn term for the user's feed.
        /// </summary>
        /// <param name="OAuth"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public XmlDocument Get_NetworkUpdates(oAuthLinkedIn OAuth, int Count)
        {
            string response = OAuth.APIWebRequest("GET", Global.GetNetworkUpdates, null);
            if(response!="")
                xmlResult.Load(new StringReader(response));
            return xmlResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="OAuth"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public string SetStatusUpdate(oAuthLinkedIn OAuth, string msg)
        {
            string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            xml += "<current-status>" + msg + "</current-status>";
            string response = OAuth.APIWebRequest("PUT", Global.StatusUpdate, xml);
            return response;
        }
    }
}