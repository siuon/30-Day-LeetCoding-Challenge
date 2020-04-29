using System;
using System.Collections.Generic;
using System.Linq;

namespace _028_First_Unique_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * You have a queue of integers, you need to retrieve the first unique integer in the queue.
  
             * Implement the FirstUnique class:
  
             * FirstUnique(int[] nums) Initializes the object with the numbers in the queue.
             * int showFirstUnique() returns the value of the first unique integer of the queue, and returns -1 if there is no such integer.
             * void add(int value) insert value to the queue.
             * 
  
             * Example 1:
  
             * Input: 
             * ["FirstUnique","showFirstUnique","add","showFirstUnique","add","showFirstUnique","add","showFirstUnique"]
             * [[[2,3,5]],[],[5],[],[2],[],[3],[]]
             * Output: 
             * [null,2,null,2,null,3,null,-1]
  
             * Explanation: 
             * FirstUnique firstUnique = new FirstUnique([2,3,5]);
             * firstUnique.showFirstUnique(); // return 2
             * firstUnique.add(5);            // the queue is now [2,3,5,5]
             * firstUnique.showFirstUnique(); // return 2
             * firstUnique.add(2);            // the queue is now [2,3,5,5,2]
             * firstUnique.showFirstUnique(); // return 3
             * firstUnique.add(3);            // the queue is now [2,3,5,5,2,3]
             * firstUnique.showFirstUnique(); // return -1
  
             * Example 2:
  
             * Input: 
             * ["FirstUnique","showFirstUnique","add","add","add","add","add","showFirstUnique"]
             * [[[7,7,7,7,7,7]],[],[7],[3],[3],[7],[17],[]]
             * Output: 
             * [null,-1,null,null,null,null,null,17]
  
             * Explanation: 
             * FirstUnique firstUnique = new FirstUnique([7,7,7,7,7,7]);
             * firstUnique.showFirstUnique(); // return -1
             * firstUnique.add(7);            // the queue is now [7,7,7,7,7,7,7]
             * firstUnique.add(3);            // the queue is now [7,7,7,7,7,7,7,3]
             * firstUnique.add(3);            // the queue is now [7,7,7,7,7,7,7,3,3]
             * firstUnique.add(7);            // the queue is now [7,7,7,7,7,7,7,3,3,7]
             * firstUnique.add(17);           // the queue is now [7,7,7,7,7,7,7,3,3,7,17]
             * firstUnique.showFirstUnique(); // return 17
  
             * Example 3:
  
             * Input: 
             * ["FirstUnique","showFirstUnique","add","showFirstUnique"]
             * [[[809]],[],[809],[]]
             * Output: 
             * [null,809,null,-1]
  
             * Explanation: 
             * FirstUnique firstUnique = new FirstUnique([809]);
             * firstUnique.showFirstUnique(); // return 809
             * firstUnique.add(809);          // the queue is now [809,809]
             * firstUnique.showFirstUnique(); // return -1
  
             * 
  
             * Constraints:
  
             * 1 <= nums.length <= 10^5
             * 1 <= nums[i] <= 10^8
             * 1 <= value <= 10^8
             * At most 50000 calls will be made to showFirstUnique and add.
             */
            var nums = new int[] { 2, 3, 5 };
            FirstUnique obj = new FirstUnique(nums);

            Console.WriteLine(obj.ShowFirstUnique() == 2);
            obj.Add(5);
            Console.WriteLine(obj.ShowFirstUnique() == 2);
            obj.Add(2);
            Console.WriteLine(obj.ShowFirstUnique() == 3);
            obj.Add(3);
            Console.WriteLine(obj.ShowFirstUnique() == -1);
        }
    }

    public class FirstUnique
    {
        private HashSet<int> _nums = new HashSet<int>();
        private HashSet<int> _pool = new HashSet<int>();

        public FirstUnique(int[] nums)
        {
            foreach (var num in nums)
            {
                Add(num);
            }
        }

        public int ShowFirstUnique()
        {
            var temp = _nums.FirstOrDefault();

            return temp == 0 ? -1 : temp;
        }

        public void Add(int value)
        {   
            if (!_pool.Any(it => it == value))
            {
                _nums.Add(value);
                _pool.Add(value);
            }
            else
            {
                _nums.Remove(value);
            }
        }
    }

    /**
     * Your FirstUnique object will be instantiated and called as such:
     * FirstUnique obj = new FirstUnique(nums);
     * int param_1 = obj.ShowFirstUnique();
     * obj.Add(value);
     */
}
