using System.Collections.Generic;

public class RepoMock{
    // attributes
    private List<int> items = new List<int> {5, 10, 15};
    public RepoMock(){
    }
    
    public int returnId(int index){
        int item = 0;
        try{
            item = items[index];
        }
        catch{
            item = 0;
        }
        return item;
    }
}