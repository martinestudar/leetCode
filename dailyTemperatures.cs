public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        List<int> answer = new List<int>();

        int lastDaysWait = 0;

        for (int i = 0; i < temperatures.Length; i++) {
            int daysWait = 0;
            int currentTemp = temperatures[i];
            bool isLast = i == temperatures.Length - 1;

            if (i > 0 && currentTemp == temperatures[i - 1]) {
                lastDaysWait = lastDaysWait == 0 ? 0 : lastDaysWait - 1;
                answer.Add(lastDaysWait);
                continue;
            }

            if (!isLast) {
                for (int x = i + 1; x < temperatures.Length; x++) {
                    int nextTemp = temperatures[x];

                    if (nextTemp > currentTemp) {
                        daysWait+=1;

                        answer.Add(daysWait);
                        lastDaysWait = daysWait;
                        break;
                    }

                    if (x == temperatures.Length - 1) {
                        lastDaysWait = 0;
                        answer.Add(lastDaysWait);
                        break;
                    }

                    daysWait++;
                }
            }
            else {
                answer.Add(daysWait);
            }
        }  

        return answer.ToArray();
    }
}
