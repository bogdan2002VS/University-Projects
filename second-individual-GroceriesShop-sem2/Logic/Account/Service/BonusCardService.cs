using DAL.DTO;
using DAL.Repository;
using Logic.Account.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Account.Service
{
    public class BonusCardService : IBonusCardService
    {
        IBonusCardRepository repo;
        public BonusCardService(IBonusCardRepository repo)
        {
            this.repo = repo;
        }
        public void CreateBonusCard(int userId)
        {

            try
            {
                var bonusCardDTO = new BonusCardDTO()
                {
                    UserId = userId,
                    TotalBonusPoints = 0
                };
                repo.CreateUserBonusCard(bonusCardDTO);

            }
            catch (Exception ex)
            {

                throw new Exception("Could not create bonus card", ex);
            }

        }

        public BonusCardModel GetBonusCard(int userId)
        {
            try
            {
                return new BonusCardModel(repo.GetBonusCard(userId));

            }
            catch (Exception ex)
            {

                throw new Exception("Could not get bonus card", ex);
            }
        }

        public void UpdateBonusCard(BonusCardModel bonusCardModel)
        {
            try
            {
                BonusCardDTO bonusCardDTO = new BonusCardDTO()
                {
                    UserId = bonusCardModel.UserModel.ID,
                    TotalBonusPoints = bonusCardModel.BonusCardPoints + bonusCardModel.BonusPointsToApply
                };
                repo.UpdateBonusCard(bonusCardDTO);
            }
            catch (Exception ex)
            {
                throw new Exception(" Error when add bonus points to Card", ex);
            }
        }

    }
}
