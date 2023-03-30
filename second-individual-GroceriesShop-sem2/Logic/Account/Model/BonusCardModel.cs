using DAL.DTO;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Account.Model
{
    public class BonusCardModel
    {
        public int BonusCardId { get; set; }
        public int BonusCardPoints { get; set; }
        public int BonusPointsToApply { get; set; }

        public UserModel? UserModel { get; set; }

        public BonusCardModel()
        {

        }

        public BonusCardModel (BonusCardDTO dto)
        {
            BonusCardId = dto.ID;
            BonusCardPoints = dto.TotalBonusPoints;
            UserModel = new UserModel()
            {
                ID = dto.UserId
            };
        }

    }
}
