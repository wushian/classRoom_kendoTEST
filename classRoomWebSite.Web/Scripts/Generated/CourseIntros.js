$(document).ready(function () {
    var crudServiceBaseUrl = "http://localhost:1867/api";
    
    var courseIntroDataSource = new kendo.data.DataSource({
        type: "json",
        transport: {
            read: {
                url: crudServiceBaseUrl + "/courseIntro",
                dataType: "json"
            },
            create: {
                url: crudServiceBaseUrl + "/courseIntro",
                dataType: "json",
                contentType: "application/json",
                type: "POST"
            },
            update: {
                url: crudServiceBaseUrl + "/courseIntro",
                dataType: "json",
                contentType: "application/json",
                type: "PUT"
            },
            destroy: {
                url: function (o) {
                    return crudServiceBaseUrl + "/courseIntro/" + o.Identification;
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
                    Name: {
                        type: "string"
                    },
                    Describe: {
                        type: "string",
                        validation: { required: true }
                    },
                    Pic1: {
                        type: "number",
                        validation: { required: true }
                    },
                    Pic2: {
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
        dataSource: courseIntroDataSource,
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
                field: "Name",
                title: "Name"
            },
            {
                field: "Describe",
                title: "Describe"
            },
            {
                field: "Pic2",
                title: "Pic 2"
            },
            {
                command: ["edit", "destroy"]
            }],
        editable: "inline"
    });
});