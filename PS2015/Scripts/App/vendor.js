app.VendorItem = Backbone.Model.extend({

});

app.VendorList = Backbone.Collection.extend({
    model: app.VendorItem,
    url: "/api/Vendor/Get/123"
});


VendorView = Backbone.Marionette.ItemView.extend({
    template: "#ps_vendor",
    tagName: 'tr',
    className: 'ps_vendor'

});

VendorLisView = Backbone.Marionette.CompositeView.extend({
    template: "#ps_vendors",
    className: 'ps_vendors',
    childView: VendorView,
    childViewContainer: "tbody"
});