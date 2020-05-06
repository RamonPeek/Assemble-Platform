export class Team {

    id: Number;
    name: String;
    creator: String;
    amountOfMembers: Number;
    
    constructor(id: Number, name: String, creator: String, amountOfMembers: Number) {
        this.id = id;
        this.name = name;
        this.creator = creator;
        this.amountOfMembers = amountOfMembers;
    }

}