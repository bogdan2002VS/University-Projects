using DAL.DTO;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Account
{
    public class BonusCardRepositoryMock : IBonusCardRepository
    {
        public BonusCardDTO BonusCardDTOAdded;

        public BonusCardDTO BonusCardDTOUpdated;

        public void CreateUserBonusCard(BonusCardDTO bonusCardDTO)
        {
            // do nothing
            BonusCardDTOAdded = bonusCardDTO;
        }

        public BonusCardDTO GetBonusCard(int userId)
        {
            if (userId == 1)
            {
                return new BonusCardDTO()
                {
                    ID = 1,
                    TotalBonusPoints = 100,
                    UserId = 12
                };
            }
            else return null;

        }

        public void UpdateBonusCard(BonusCardDTO bonusCardDTO)
        {
            BonusCardDTOUpdated = bonusCardDTO;
        }
    }
}
