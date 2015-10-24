app.ExecInfo = Backbone.Model.extend({

});

app.ExecInfoList = Backbone.Collection.extend({
    model: app.ExecInfo,
    url: "/api/BN/Get/123"
});

ExecInfoView = Backbone.Marionette.ItemView.extend({
    template: "#ps_execinfo",
    //tagName: "tr",
    className: 'ps_execinfo',
});