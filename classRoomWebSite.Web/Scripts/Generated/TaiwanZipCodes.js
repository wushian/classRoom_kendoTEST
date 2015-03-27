$(document).ready(function () {
    var crudServiceBaseUrl = "http://localhost:1867/api";
    
    var taiwanZipCodeDataSource = new kendo.data.DataSource({
        type: "json",
        transport: {
            read: {
                url: crudServiceBaseUrl + "/taiwanZipCode",
                dataType: "json"
            },
            create: {
                url: crudServiceBaseUrl + "/taiwanZipCode",
                dataType: "json",
                contentType: "application/json",
                type: "POST"
            },
            update: {
                url: crudServiceBaseUrl + "/taiwanZipCode",
                dataType: "json",
                contentType: "application/json",
                type: "PUT"
            },
            destroy: {
                url: function (o) {
                    return crudServiceBaseUrl + "/taiwanZipCode/" + o.Identification;
                },
                dataType: "json",
                type: "DELETE"
            },
            parameterMap: function(data) {
                return JSON.stringify(data);
            }
        },
        schema: {
            data: function (result) {
                return result.Data || result;
            },
            total: function (result) {
                return result.TotalCount || 1;
            },
            model: {
                id: "Identification",
                fields: {
                    Identification: {
                        type: "number",
                        editable: false
                    },
                    Zip: {
                        type: "number"
                    },
                    CityName: {
                        type: "string"
                    },
                    Town: {
                        type: "string"
                    },
                    Sequence: {
                        type: "number"
                    },
                    CreateDate: {
                        type: "date"
                    }
                }
            }
        },
        serverFiltering: true,
        serverSorting: true,
        allowUnsort: true,
        serverPaging: true,
        pageSize: 5
    });
    var grid = $("#grid").kendoGrid({
        dataSource: taiwanZipCodeDataSource,
        pageable: true,
        filterable: true,
        sortable: true,
        navigatable: true,
        columns: [
            {
                field: "Identification",
                title: "Identification",
                filterable: false
            },
            {
                field: "Zip",
                title: "Zip"
            },
            {
                field: "CityName",
                title: "City Name"
            },
            {
                field: "Town",
                title: "Town"
            },
            {
                field: "Sequence",
                title: "Sequence"
            },
            {
                field: "CreateDate",
                title: "Create Date"
            },
            {
                command: ["edit", "destroy"]
            }],
        editable: "inline"
    });
});