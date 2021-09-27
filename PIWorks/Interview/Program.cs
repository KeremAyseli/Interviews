using System;
using System.Collections.Generic;
using System.Linq;
namespace Interview
{
    class Program
    {
        /// <summary>
        /// IndexAndValues ​​keeps indexes and values ​​as a single object, returning values ​​whenever desired.
        /// IndexAndValues, indeksleri ve değerleri tek bir nesne olarak tutar, istendiğinde değerleri döndürür.
        /// </summary>
        /// <param name="index">int</param>
        /// <param name="values">int</param>
        public struct IndexAndValues
        {
            public int index { get; set; }
            public int values { get; set; }
            public int lastSum { get; set; }
            public int layerNumber { get; set; }
            public List<int> path { get; set; }
            public IndexAndValues(int index, int values, int lastSum, int layerNumber, List<int> path)
            {
                this.index = index;
                this.values = values;
                this.lastSum = lastSum;
                this.layerNumber = layerNumber;
                this.path = path;
            }
        }
        /// <summary>
        /// This structure is used for the path with the largest result.Structure needs 3 params;First is path type in List<int>,
        /// second is max Value of path type in int,third is last Index Of Layer.
        /// </summary>
        /// <param name="path">List<int></param>
        /// <param name="maxValue">int</param>
        /// <param name="lastIndexOfLayer">int</param>
        public struct MaxValueAndMaxValuePath
        {
            public List<int> path { get; set; }
            public int maxValue { get; set; }
            public int lastIndexOfLayer { get; set; }
            public MaxValueAndMaxValuePath(List<int> path, int maxValue,int lastIndexOfLayer)
            {
                this.path = path;
                this.maxValue = maxValue;
                this.lastIndexOfLayer = lastIndexOfLayer;
            }
        }
        //The layers of the pyramid consist of string[]. Pyramid consists of List<string> type.
        //Piramid List<string> tipinden oluşur.Katmanlar string[] dizilereden oluşur.
        static List<string[]> pyramid = new() {
            new string[] { "1" }, 
            new string[] { "8", "4" }, 
            new string[] { "2", "6", "9" }, 
            new string[] { "8", "5", "9", "3" } };
        static List<MaxValueAndMaxValuePath> allPathSum = new List<MaxValueAndMaxValuePath>();
        static void Main(string[] args)
        {
            List<int> myPath = new List<int>();
            int total = 0;
            int lastIndexOfLayer = 0;
            //LastIndex is 0 because every pyramid first layer is start from 0 length.
            //LastIndex değeri 0 çünkü piramidin ilk katmanının uzunluğu her zaman 0.
            int lastIndex = 0;
            for (int i = 0; i < pyramid.Count; i++)
            {
                //Geçerli katmanın kullanıldığı yer.
                //where the current layer is used.
                string[] numbers = pyramid[i];

                //I determine the crossRIndex and crossLIndex value using the ternary operator because the right index value may be longer than the length of the list.
                //Sağ ve Sol indeks değeri listenin uzunluğundan daha uzun olabileceğinden, crossRIndex and corssLIndex Index değerini ternary operator kullanarak belirliyorum.
                int crossRIndex = numbers.Length <= lastIndex + 1 ? numbers.Length - 1 : lastIndex + 1;
                int linear = Convert.ToInt32(numbers[lastIndex]);
                int crossR = Convert.ToInt32(numbers[crossRIndex]);

                //I define and add the potential indexes and values ​​I get to the IndexAndValues ​​type list.
                //Elde ettiğim potansiyel indeksleri ve değerleri IndexAndValues tipindeki listeyi tanımlayıp ekliyorum.
                List<IndexAndValues> idByIndex = new List<IndexAndValues>();
                idByIndex.Add(new IndexAndValues(lastIndex, linear, total, i, myPath));
                idByIndex.Add(new IndexAndValues(crossRIndex, crossR, total, i, myPath));

                //Send  List<IndexAndValues> data to BubbleSort method and learn which is bigger have values .Than add to total varriable.
                //BubbleSort algoritmasına,eklediğim IndexAndValues değerlerini veriyorum ve en büyük değeri alıp bastırıyorum.
                IndexAndValues nextMove = BubbleSort(idByIndex);
                if (nextMove.values == -1) {
                    break;
                }
                else {
                    myPath.Add(nextMove.values);
                    //Set the last index of non prime number.
                    //En son olan asal sayının indeksini lastIndex değişkenine atıyorum.
                    lastIndex = nextMove.index;
                    //Add non prime number to total varriable
                    total += nextMove.values;
                }
                lastIndexOfLayer = i;
            }

            allPathSum.Add(new MaxValueAndMaxValuePath(myPath, total,lastIndexOfLayer));
            BubbleSortForLayers(BubbleSort(allPathSum));

        }
        /// <summary>
        /// This method sorte MaxValueAndMaxValuePath items by index number to big to small
        /// </summary>
        /// <param name="maxValueAndMaxValuePaths"></param>
        public static void BubbleSortForLayers(List<MaxValueAndMaxValuePath> maxValueAndMaxValuePaths)
        {
            for(int i = 0; i < maxValueAndMaxValuePaths.Count; i++)
            {
                MaxValueAndMaxValuePath temp;
                for(int j = i; j < maxValueAndMaxValuePaths.Count; j++)
                {
                    if (maxValueAndMaxValuePaths[i].lastIndexOfLayer < maxValueAndMaxValuePaths[j].lastIndexOfLayer)
                    {
                        temp = maxValueAndMaxValuePaths[i];
                        maxValueAndMaxValuePaths[i] = maxValueAndMaxValuePaths[j];
                        maxValueAndMaxValuePaths[j] = temp;
                    }
                }
            }
            Console.WriteLine("En dibe ulaşan en büyük toplama sahip yollar\nBüyükten Küçüğe\n=================================================");
            for (int i = 0; i < maxValueAndMaxValuePaths.Count; i++)
            {
                Console.WriteLine("Yol başlangıç\n");
                for(int j = 0; j < maxValueAndMaxValuePaths[i].path.Count; j++)
                {
                    Console.WriteLine(maxValueAndMaxValuePaths[i].path[j].ToString());
                }
                Console.WriteLine("\nYol bitiş\n\nYolun Toplam değeri:"+ maxValueAndMaxValuePaths[i].maxValue+"\n=================================================");
                
            }
        } 
        /// <summary>
        /// This method sort MaxValuesAndMaxValuePath item by maxValue varriable to big to small.
        /// </summary>
        /// <param name="maxValueAndMaxValues"></param>
        /// <returns></returns>
        public static List<MaxValueAndMaxValuePath> BubbleSort(List<MaxValueAndMaxValuePath> maxValueAndMaxValues)
        {
            for (int i = 0; i < maxValueAndMaxValues.Count; i++)
            {
                MaxValueAndMaxValuePath temporary;
                for (int j = i; j < maxValueAndMaxValues.Count; j++)
                {
                    if (maxValueAndMaxValues[i].maxValue < maxValueAndMaxValues[j].maxValue)
                    {
                        temporary = maxValueAndMaxValues[i];
                        maxValueAndMaxValues[i] = maxValueAndMaxValues[j];
                        maxValueAndMaxValues[j] = temporary;
                    }
                }
            }
            return maxValueAndMaxValues.Take(maxValueAndMaxValues.Count > 20 ? 20 : 3).ToList();

        }
            /// <summary>
            /// If number is a prime number return true,if not number is prime number return false.
            /// IsPrime metodu verilen sayıyının asal sayı olup olmadığını bulur ve geriye TRUE ya da FALSE bir değer döndürür.
            /// </summary>
            /// <param name="number">int number</param>
            /// <returns>Bool</returns>
            public static bool IsPrime(int number)
            {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        /// <summary>
        /// BubbleSort method is sorting algorithm,return the biggest number.
        /// BubbleSort algoritması verilen listedeki en büyük değeri bulur ve geri IndexAndValues tipinde bir değer döndürür.
        /// </summary>
        /// <param name="indexAndNumber">List<IndexAndValues> indexAndNumber</param>
        /// <returns>IndexAndValues</returns>
        public static IndexAndValues BubbleSort(List<IndexAndValues> indexAndNumber)
        {
            indexAndNumber = PrimeCleaner(indexAndNumber);
            if (indexAndNumber.Count > 0)
            {
                for (int i = 0; i < indexAndNumber.Count; i++)
                {
                    IndexAndValues temporary;
                    for (int j = i; j < indexAndNumber.Count; j++)
                    {
                        if (indexAndNumber[i].values < indexAndNumber[j].values)
                        {
                            temporary = indexAndNumber[i];
                            indexAndNumber[i] = indexAndNumber[j];
                            indexAndNumber[j] = temporary;
                        }
                    }
                }
              indexAndNumber=  indexAndNumber.Distinct().ToList();
                if (indexAndNumber.Count >= 2)
                {
                    for (int i = 1; i < indexAndNumber.Count; i++)
                    {
                        PathMake(indexAndNumber[i]);
                    }
                }
                return indexAndNumber[0];
            }
            else if (indexAndNumber.Count==0)
            {
                return new IndexAndValues(-1,-1,-1,-1,new List<int>());
            }
            else
            {
                return indexAndNumber[0];
            }
        }
        /// <summary>
        /// PrimeCleaner is find nonprime number,add in IndexAndValues type list and return it.
        /// PrimeCleaner metodu gelen listede asal olan sayıları listeden çıkaratarak,daha rahat bir sıralama yapılmasını sağlar.
        /// </summary>
        /// <param name="indexAndNumber">List<IndexAndValues> indexAndNumber</param>
        /// <returns>List<IndexAndValues></returns>
        public static List<IndexAndValues> PrimeCleaner(List<IndexAndValues> indexAndNumber)
        {
            List<IndexAndValues> nonprimenumber = new List<IndexAndValues>();
            for (int i = 0; i < indexAndNumber.Count; i++)
            {
                if (!IsPrime(indexAndNumber[i].values))
                {
                    nonprimenumber.Add(indexAndNumber[i]);
                }
            }
            return nonprimenumber;
        }
        public static void PathMake(IndexAndValues otherNumber)
        {
            List<int> myPath = otherNumber.path.ToList();
            myPath.Add(otherNumber.values);
            int total = otherNumber.lastSum+otherNumber.values;
            int lastIndex = otherNumber.index;
            int lastIndexOfLayer = 0;
            
            for(int i = otherNumber.layerNumber+1; i < pyramid.Count; i++)
            {
                string[] numbers = pyramid[i];
                //I determine the crossRIndex and crossLIndex value using the ternary operator because the right index value may be longer than the length of the list.
                //Sağ ve Sol indeks değeri listenin uzunluğundan daha uzun olabileceğinden, crossRIndex and corssLIndex Index değerini ternary operator kullanarak belirliyorum.
                int crossRIndex = numbers.Length <= lastIndex + 1 ? numbers.Length - 1 : lastIndex + 1;
                int linear = Convert.ToInt32(numbers[lastIndex]);
                int crossR = Convert.ToInt32(numbers[crossRIndex]);
                List<IndexAndValues> idByIndex = new List<IndexAndValues>();
                idByIndex.Add(new IndexAndValues(lastIndex, linear, total, i,myPath));
                idByIndex.Add(new IndexAndValues(crossRIndex, crossR, total, i, myPath));
                //Send  List<IndexAndValues> data to BubbleSort method and learn which is bigger have values .Than add to total varriable.
                //BubbleSort algoritmasına,eklediğim IndexAndValues değerlerini veriyorum ve en büyük değeri alıp bastırıyorum.
                IndexAndValues nextMove = BubbleSort(idByIndex);
                if (nextMove.values == -1)
                {
                    break;
                }
                else
                {
                    myPath.Add(nextMove.values);
                    //Set the last index of non prime number.
                    //En son olan asal sayının indeksini lastIndex değişkenine atıyorum.
                    lastIndex = nextMove.index;
                    //Add non prime number to total varriable
                    total += nextMove.values;
                }
                lastIndexOfLayer = i;
            }
            allPathSum.Add(new MaxValueAndMaxValuePath(myPath, total,lastIndexOfLayer));
        }
        
    }
}
