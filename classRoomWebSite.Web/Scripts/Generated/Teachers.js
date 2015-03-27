$(document).ready(function () {
    var crudServiceBaseUrl = "http://localhost:1867/api";
    
    var teacherDataSource = new kendo.data.DataSource({
        type: "json",
        transport: {
            read: {
                url: crudServiceBaseUrl + "/teacher",
                dataType: "json"
            },
            create: {
                url: crudServiceBaseUrl + "/teacher",
                dataType: "json",
                contentType: "application/json",
                type: "POST"
            },
            update: {
                url: crudServiceBaseUrl + "/teacher",
                dataType: "json",
                contentType: "application/json",
                type: "PUT"
            },
            destroy: {
                url: function (o) {
                    return crudServiceBaseUrl + "/teacher/" + o.Identification;
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
                    PicFile: {
                        type: "string",
                        validation: { required: true }
                    },
                    Name: {
                        type: "string"
                    },
                    Gender: {
                        type: "string",
                        validation: { required: true }
                    },
                    CreateDate: {
                        type: "date"
                    },
                    BirthDay: {
                        type: "date",
                        validation: { required: true }
                    },
                    Address: {
                        type: "string",
                        validation: { required: true }
                    },
                    OfficeAddress: {
                        type: "string",
                        validation: { required: true }
                    },
                    TelPhone: {
                        type: "string",
                        validation: { required: true }
                    },
                    CellPhone: {
                        type: "string",
                        validation: { required: true }
                    },
                    Job: {
                        type: "string",
                        validation: { required: true }
                    },
                    Ability: {
                        type: "string",
                        validation: { required: true }
                    },
                    Educational: {
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
        dataSource: teacherDataSource,
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
                field: "PicFile",
                title: "Pic File"
            },
            {
                field: "Name",
                title: "Name"
            },
            {
                field: "Gender",
                title: "Gender"
            },
            {
                field: "CreateDate",
                title: "Create Date"
            },
            {
                field: "BirthDay",
                title: "Birth Day"
            },
            {
                field: "Address",
                title: "Address"
            },
            {
                field: "OfficeAddress",
                title: "Office Address"
            },
            {
                field: "TelPhone",
                title: "Tel Phone"
            },
            {
                field: "CellPhone",
                title: "Cell Phone"
            },
            {
                field: "Job",
                title: "Job"
            },
            {
                field: "Ability",
                title: "Ability"
            },
            {
                field: "Educational",
                title: "Educational"
            },
            {
                command: ["edit", "destroy"]
            }],
        editable: "inline"
    });
});