using System.Collections.Generic;

public class RepoMock : RepoInterface{
    private List<Item> items;
    public RepoMock(){
        items = new List<Item> {
            new Item(1, "Item 1"),
            new Item(2, "Item 2"),
            new Item(3, "Item 3"),
        };
    }
    
    public string returnItem(int index){
        string item = "Item -1";
        foreach(Item i in items){
            if(i.getId() == index){
                item = i.getName();
            }
        }
        return item;
    }
}