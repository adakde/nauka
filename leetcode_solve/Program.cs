//1431. Kids With the Greatest Number of Candies
// Easy
// Topics
// Companies
// Hint
// There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

// Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

// Note that multiple kids can have the greatest number of candies.


using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        //maxValue z arraylisty
        int maxValue = candies.Max();
        IList<bool> result = new List<bool>();
        //petla for sprawdzajaca czy dziecko ma szansę mieć najwięcej cukierów
        for(int i = 0; i < candies.Length; i++) {
            if(candies[i] + extraCandies >= maxValue) {
                result.Add(true);
            } else {
                result.Add(false);
            }
        }
        
        return result;
    }
}
