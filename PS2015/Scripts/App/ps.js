app.PS = Backbone.Model.extend({
    url: "/api/Passport/123"
});

PSView = Backbone.Marionette.ItemView.extend({
    template: "#ps_maininfo",
    className: 'ps_maininfo',
});