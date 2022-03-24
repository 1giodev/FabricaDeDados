const express = require('express');
const router = express.Router();

router.get('/', function (req, res, next) {
    res.status(200).send({
        title: "Node Express API",
        version: "0.0.1"
    });
});

router.get('/pessoa/', function (req, res, next) {
    res.status(200).send({
        title: "Node Express Pessoa API",
        version: "0.0.1"
    });
});

router.get('/empresa/', function (req, res, next) {
    res.status(200).send({
        title: "Node Express empresa API",
        version: "0.0.1"
    });
});

router.get('/endereco/', function (req, res, next) {
    res.status(200).send({
        title: "Node Express endereco API",
        version: "0.0.1"
    });
});

router.get('/cartaoDeCredito/', function (req, res, next) {
    res.status(200).send({
        title: "Node Express cartaoDeCredito API",
        version: "0.0.1"
    });
});

router.get('/contaBancaria/', function (req, res, next) {
    res.status(200).send({
        title: "Node Express contaBancaria API",
        version: "0.0.1"
    });
});

module.exports = router;