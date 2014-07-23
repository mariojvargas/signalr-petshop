SignalR Pet Shoppe Demo
=======================

This demo presents a simplified E-Commerce shopping experience. The user can add pets to the shopping cart. The shopping cart and the list of products exist on the same page. The **Processing Department** simulates the backend administration interface that a department employee will access to monitor incoming orders.

When the user checks out their order, the list of selected shopping cart items is immediately posted to the CheckoutController. This controller creates a new order based off of the given list of cart items, which are now converted to order detail entries. A new order ID and date is created. This complete order information is delegated to the OrderProcessHub, a SignalR hub, and a subset of the order's information is returned as a successful response to the shopping cart user.

When the CheckoutController pushes a new order, this order is displayed in real time on the Processing Department page via a SignalR client connected to the OrderProcessHub.

This demo uses the following technologies:

   * MVC 5.1
   * Web API 2.2
   * SignalR 2.1
   * KnockoutJS 3.1
   * jQuery 1.10
   * HTML, CSS, JavaScript
   * Bootstrap 3.0
