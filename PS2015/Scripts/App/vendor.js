app.VendorItem = Backbone.Model.extend({

});

app.VendorList = Backbone.Collection.extend({
    model: app.VendorItem,
    url: "/api/Vendor/Get/123"
});


VendorView = Backbone.Marionette.ItemView.extend({
    template: "#ps_vendor",
    tagName: 'tr',
    className: 'ps_vendor',
    ui: {
        deleter: ".deletevendor"
    },
    events: {
        'click @ui.deleter': 'clickedDeleter'
    },
    clickedDeleter: function () {
        //alert("Deleted");
        debugger;
        this.model.destroy();
    }

});

VendorLisView = Backbone.Marionette.CompositeView.extend({
    template: "#ps_vendors",
    className: 'ps_vendors',
    childView: VendorView,
    childViewContainer: "tbody",

    ui: {
        adder: ".addvendor"
    },
    events: {
        'click @ui.adder': 'clickedAdder'
    },
    clickedAdder: function () {
        //debugger;
        var newVendor = new app.VendorItem({
            VendorName: "",
            Cost: 0,
            Buy: 0,
            SrokKredit: 0,
            RasxodKredit: 0,
            BN: "",
            DeliveryCost: 0,
            Comments: 0
        });

        this.collection.add(newVendor);
    }
});