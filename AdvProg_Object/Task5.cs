using System.Collections;

namespace AdvProg_Object;

public class VoteTable
{
    private readonly Hashtable _votes;
   
    public VoteTable()
    {
        _votes = new Hashtable();
    }

    public void AddCandidate(string name, int votesCount)
    {
        _votes.Add(name, votesCount);
    }

    public void ViewVotes()
    {
        DictionaryEntry winner = new DictionaryEntry("",0);
        foreach (DictionaryEntry candidateInfo in _votes)
        {
            if (candidateInfo.Value == null) continue;
           
            if ((int)candidateInfo.Value > (int)winner.Value!)
                winner = candidateInfo;
            Console.WriteLine($"{candidateInfo.Key}\t - {candidateInfo.Value}");
        }
       
        Console.WriteLine($"Победитель выборов: {winner.Key}");
    }
}