app.BNSumList = Backbone.Model.extend({

});

app.BNSumLists = Backbone.Collection.extend({
    model: app.BNSumList,
    url: "/api/BN/Get/123"
});

BNCountView = Backbone.Marionette.ItemView.extend({
    template: "#ps_bncountitem",
    tagName: 'tr',
    className: 'ps_bncountitem'

});

BNCountCollectionView = Backbone.Marionette.CompositeView.extend({
    template: "#ps_bncount",
    className: 'ps_bncount',
    childView: BNCountView,
    childViewContainer: "tbody"
});