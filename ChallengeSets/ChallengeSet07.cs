﻿using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            var ans = 0;
            if (businesses == null)
            {
                return ans;
            }
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue - biz.TotalExpenses <= 0)
                {
                    ans++;
                }
            }
            return ans;
            //throw new NotImplementedException();
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            var ansList = new List<string>();
            var ansStr = "";
            var ans = "";
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue > biz.TotalExpenses)
                {
                    ansList.Add(biz.Name.ToString());
                }
            }
            foreach (var profitable in ansList)
            {
                ansStr += profitable + ",";
            }
            for (int i = 0; i < ansStr.Length -1; i++)
            {
                ans += ansStr[i];
            }

            
            return ans;
            //throw new NotImplementedException();
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            throw new NotImplementedException();
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            throw new NotImplementedException();
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
