class Item{
    // attributes

    private int id;
    private string name;

    public Item(int id, string name){
        this.id = id;
        this.name = name;
    }

    public int getId(){
        return this.id;
    }

    public string getName(){
        return this.name;
    }

    public void setId(int id){
        this.id = id;
    }

    public void setName(string name){
        this.name = name;
    }
}