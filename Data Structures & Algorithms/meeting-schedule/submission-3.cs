/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        if (intervals == null || intervals.Count() == 0) return true;
        var srtdInterval = intervals.OrderBy(i => i.start).ToList();

        var endInterval = srtdInterval[0].end;
        var startInterval = srtdInterval[0].start;

       
        for (int i=1; i < intervals.Count(); i++){

             if(srtdInterval[i].start < endInterval) {
                return false;
             }
              endInterval = srtdInterval[i].end;
              startInterval = srtdInterval[i].start;
        }

        return true;
    }
}
