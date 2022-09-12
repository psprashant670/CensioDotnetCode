using System;
using System.Collections.Generic;

namespace Domain.Game4DataEntites
{
    public partial class TblUsers
    {
        public int UserId { get; set; }
        public int? IdOrganization { get; set; }
        public string LoginUserId { get; set; }
        public string Password { get; set; }
        public string AvatarUserName { get; set; }
        public string Status { get; set; }
        public int? IdAvatar { get; set; }
    }
}
