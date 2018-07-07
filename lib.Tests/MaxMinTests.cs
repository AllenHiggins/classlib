using Xunit;
using classlib;

namespace lib.Tests
{
    public class MaxMinTests
    {
        MaxMin maxMin = new MaxMin();

        [Fact]
        public void retrunMaxMinString()
        {
            // Arrange
            int[] list = {1,2,3,4,5};
            
            // Act
            string result = maxMin.findMaxMin(list);
            
            // Assert
            Assert.Equal("14 10", result);
        }

        [Fact]
        public void retrunMaxMinString2()
        {
            // Arrange
            int[] list = {1,2,3,4,5,6,-7};
            
            // Act
            string result = maxMin.findMaxMin(list);
            
            // Assert
            Assert.Equal("21 8", result);
        }

        [Fact]
        public void returnNewMaxValue()
        {
            // Arrange
            int result = maxMin.setMax(544, 5);
            Assert.Equal(544,result);
        }

        [Fact]
        public void returnMaxValueAsIs()
        {
            // Arrange
            int result = maxMin.setMax(5, 544);
            Assert.Equal(544,result);
        }

        [Fact]
        public void retrunMaxValue()
        {
            // Arrange
            int result = maxMin.setMax(54, 54);
            Assert.Equal(54,result);
        }

        [Fact]
        public void returnMinValueAsIs()
        {
            // Arrange
            int result = maxMin.setMin(544, 5);
            Assert.Equal(5,result);
        }

        [Fact]
        public void returnNewMinValue()
        {
            // Arrange
            int result = maxMin.setMin(33, 544);
            Assert.Equal(33,result);
        }

         [Fact]
        public void returnMinValue()
        {
            // Arrange
            int result = maxMin.setMin(33, 33);
            Assert.Equal(33,result);
        }

        [Fact]
        public void returnSumTotalWithoutIndexValue0()
        {
            // Arrange
            int[] list = {1,2,3,4,5,6,-7};
            int result = maxMin.holdOneGetSum(list,0);
            Assert.Equal(13,result);
        }

         [Fact]
        public void returnSumTotalWithoutIndexValue1()
        {
            // Arrange
            int[] list = {1,2,3,4,5,6,-7};
            int result = maxMin.holdOneGetSum(list,1);
            Assert.Equal(12,result);
        }

         [Fact]
        public void returnSumTotalWithoutIndexValue6()
        {
            // Arrange
            int[] list = {1,2,3,4,5,6,-7};
            int result = maxMin.holdOneGetSum(list,6);
            Assert.Equal(21,result);
        }

         [Fact]
        public void returnSumTotalWithoutIndexValue4()
        {
            // Arrange
            int[] list = {1,2,3,4,5,6,-7};
            int result = maxMin.holdOneGetSum(list,4);
            Assert.Equal(9,result);
        }
    }
}
