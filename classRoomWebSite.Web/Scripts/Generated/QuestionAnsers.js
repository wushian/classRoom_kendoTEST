$(document).ready(function () {
    var crudServiceBaseUrl = "http://localhost:1867/api";
    
    var questionAnserDataSource = new kendo.data.DataSource({
        type: "json",
        transport: {
            read: {
                url: crudServiceBaseUrl + "/questionAnser",
                dataType: "json"
            },
            create: {
                url: crudServiceBaseUrl + "/questionAnser",
                dataType: "json",
                contentType: "application/json",
                type: "POST"
            },
            update: {
                url: crudServiceBaseUrl + "/questionAnser",
                dataType: "json",
                contentType: "application/json",
                type: "PUT"
            },
            destroy: {
                url: function (o) {
                    return crudServiceBaseUrl + "/questionAnser/" + o.Identification;
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
                        type: "string",
                        validation: { required: true },
                        editable: false
                    },
                    Cat1: {
                        type: "number",
                        validation: { required: true }
                    },
                    Cat2: {
                        type: "number",
                        validation: { required: true }
                    },
                    Pic1: {
                        type: "string",
                        validation: { required: true }
                    },
                    Pic2: {
                        type: "string",
                        validation: { required: true }
                    },
                    Describe: {
                        type: "string",
                        validation: { required: true }
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
        dataSource: questionAnserDataSource,
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
                field: "Cat1",
                title: "Cat 1"
            },
            {
                field: "Cat2",
                title: "Cat 2"
            },
            {
                field: "Pic1",
                title: "Pic 1"
            },
            {
                field: "Pic2",
                title: "Pic 2"
            },
            {
                field: "Describe",
                title: "Describe"
            },
            {
                command: ["edit", "destroy"]
            }],
        editable: "inline"
    });
});