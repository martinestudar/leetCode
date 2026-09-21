using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);

        IList<int> answer1 = new List<int>();
        IList<int> answer2 = new List<int>();

        foreach (int num in set1) {
            if (!set2.Contains(num)) {
                answer1.Add(num);
            }
        }

        foreach (int num in set2) {
            if (!set1.Contains(num)) {
                answer2.Add(num);
            }
        }
      
        return new List<IList<int>> { answer1, answer2 };
    }
}
