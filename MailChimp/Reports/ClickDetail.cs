using System.Runtime.Serialization;
using System.Collections.Generic;
using MailChimp.Lists;

namespace MailChimp.Reports
{
    [DataContract]
    public class ClickDetail
    {
        /// <summary>
        ///the total number of records matched to the URL and campaign
        /// </summary>
        /// 
        [DataMember(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// structs for each click member matching
        /// </summary>
        [DataMember(Name = "data")]
        public List<ClickDetailData> Data { get; set; }

    }

    [DataContract]
    public class ClickDetailData
    {
        /// <summary>
        /// the member record as returned by lists/member-info()
        /// </summary>
        [DataMember(Name = "member")]
        public MemberInfo Member { get; set; }

        /// <summary>
        /// Total number of times the URL was clicked by this email address
        /// </summary>
        [DataMember(Name = "clicks")]
        public int Clicks { get; set; }
    }
}