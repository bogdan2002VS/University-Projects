using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IBonusCardRepository
    {
        public void CreateUserBonusCard(BonusCardDTO bonusCardDTO);
        public BonusCardDTO GetBonusCard(int userId);

        public void UpdateBonusCard(BonusCardDTO bonusCardDTO);
    }
}
