

export class ItemModel {
  public id?: number;
  public name?: string;
  public type?: number;
  public weight?: number;
  public shelfLife?: Date;
  public image?: string;
  public about?: string;
  public warehouse?: number;
  public price?: number;
  public quantity?: number;
  public new_price?: number;
  constructor(
    source: any
    /*
     id?: number,
    name?: string,
    type?: number,
    weight?: number,
    shelfLife?: Date,
    image?: string,
    about?: string,
    warehouse?: number,
    price?: number,
    quantity?: number,
    new_price?: number
    */
  ) {
    this.id = source.id;
    this.name = source.name;
    this.type = source.type;
    this.weight = source.weight;
    this.shelfLife = source.shelfLife;
    this.image = source.image;
    this.about = source.about;
    this.warehouse = source.warehouse;
    this.price = source.price;
    this.quantity = source.quantity;
    this.new_price = source.new_price;
  }
  toJSON() {
    return {
      id: this.id,
      name: this.name,
      type: this.type,
      weight: this.weight,
      shelfLife: this.shelfLife,
      image: this.image,
      about: this.about,
      warehouse: this.warehouse,
      price: this.price,
      quantity: this.quantity,
      new_price: this.new_price
    }
  }
}
