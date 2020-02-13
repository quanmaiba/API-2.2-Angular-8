import { Component, OnInit, Inject } from "@angular/core";
import { MAT_DIALOG_DATA, MatDialogRef } from "@angular/material";
import { OrderItemsComponent } from "./order-items/order-items.component";
import { OrderItem } from "../shared/order-item.model";

@Component({
  selector: "app-orders",
  templateUrl: "./orders.component copy.html",
  styleUrls: ["./orders.component.css"]
})
export class OrdersComponent implements OnInit {
  formData: OrderItem;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data,
    public dialogRef: MatDialogRef<OrderItemsComponent>) {}

  ngOnInit() {
    this.formData = {
      OrderItemID: null,
      OrderID: this.data.OrderID,
      ItemID: 0,
      ItemName: "",
      Price: 0,
      Quantity: 0,
      Total: 0
    };
  }
}
