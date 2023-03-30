using Logic.Account.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Account.Service
{
    public interface IBonusCardService
    {
        public void CreateBonusCard(int userId);
        public BonusCardModel GetBonusCard(int userId);

        public void UpdateBonusCard(BonusCardModel bonusCardModel);
    }
}
