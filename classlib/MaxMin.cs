using System;

namespace classlib
{
    public class MaxMin
    {
        public MaxMin(){}

        public string findMaxMin(int[] list){
            int count = 0, sum = 0, max = 0, min = 2147483647;
            while(count <= list.Length-1){
               sum = holdOneGetSum(list, count);
               max = setMax(sum, max);
               min = setMin(sum, min);
               count++;
           }
           return $"{max} {min}";
        }

        public int holdOneGetSum(int[] list, int index){
            int sum = 0;
           
            for(int i = 0; i <= list.Length-1; ++i){
                if( index == i){
                    continue;
                }else{
                    sum += list[i];
                } 
            }

            return sum;
        }

        public int setMax(int number, int max){
            if(max < number){ max = number;}
            return max;
        }

        public int setMin(int number, int min){
            if(min > number){
                min = number;
            }
            return min;
        }
    }
}
