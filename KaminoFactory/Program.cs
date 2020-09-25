using System;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLendth = int.Parse(Console.ReadLine());
            string[] dnaSequence = new string[dnaLendth];
            string[] bestSequence = new string[dnaLendth];
            string[] bestSequenceSumm = new string[dnaLendth];
            int bestCounter = 0;
            int bestIndex = int.MaxValue;
            int bestIndexSum = int.MaxValue;
            int inputNumberCounter = 0;
            int inputNumberCounterSum = 0;
            int currCounter = 1;
            int bestSequenceSum = 0;
            int j = 0;
            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                string[] splitedInput = input.Split('!');
                inputNumberCounter++;
                int sequenceSum = 0;
                for (j = 0; j < splitedInput.Length; j++)
                {
                    currCounter = 1;
                    int curr = int.Parse(splitedInput[j]);
                    sequenceSum += curr;

                    for (int k = j + 1; k < splitedInput.Length; k++)
                    {
                        int next = int.Parse(splitedInput[k]);
                        if (curr == 1 && next == 1)
                        {
                            currCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currCounter >= bestCounter)
                    {
                        bestCounter = currCounter;
                        bestIndex = j;

                        bestSequence = splitedInput;

                        if (j < bestIndex)
                        {
                            bestCounter = currCounter;
                            bestIndex = j;
                            bestSequence = splitedInput;
                        }

                    }

                }
                if (sequenceSum > bestSequenceSum)
                {
                    bestSequenceSum = sequenceSum;
                    bestIndexSum = bestIndex;
                    bestSequenceSumm = splitedInput;
                    inputNumberCounterSum = inputNumberCounter;
                }

            }
            if (currCounter >= bestSequenceSum &&bestIndex<=bestIndexSum)
            {
                Console.WriteLine($"Best DNA sample {inputNumberCounter} with sum: {bestCounter}.");
                Console.WriteLine(string.Join(" ", bestSequence));
            }
            else
            {
                Console.WriteLine($"Best DNA sample {inputNumberCounterSum} with sum: {bestSequenceSum}.");
                Console.WriteLine(string.Join(" ", bestSequenceSumm));
            }
        }
    }
}
