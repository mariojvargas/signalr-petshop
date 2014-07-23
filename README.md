SignalR Pet Shoppe Demo
=======================

This demo presents a simplified E-Commerce shopping experience. The user can add pets to the shopping cart. The shopping cart and the list of products exist on the same page. The "Processing Department" page simulates the backend administration interface that a department employee will access to monitor incoming orders.

When the user checks out their order, the list of selected shopping cart items is immediately posted to the **CheckoutController**. This controller creates a new order based off of the given list of cart items, which are now converted to order detail entries associated with a new order ID and date of purchase. This complete order information is delegated to the **OrderProcessHub**, a SignalR hub. A subset of the order's information is returned as a successful response (i.e. **OkNegotiatedContentResult**) to the shopping cart user.

When the **CheckoutController** pushes a new order, this order is displayed in real time on the Processing Department page via a SignalR client connected to the **OrderProcessHub**.

We could easily replace the Web API **CheckoutController** with a SignalR hub that accomplishes the same purpose.

This demo uses the following technologies:

   * MVC 5.1
   * Web API 2.2
   * SignalR 2.1
   * KnockoutJS 3.1
   * jQuery 1.10
   * HTML, CSS 3, JavaScript
   * Bootstrap 3.0
