/**
 * BitMEX API
 * ## REST API for the BitMEX Trading Platform  [View Changelog](/app/apiChangelog)    #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  *All* table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  *This is only a small subset of what is available, to get you started.*  Fill in the parameters and click the `Try it out!` button to try any of these queries.  * [Pricing Data](#!/Quote/Quote_get)  * [Trade Data](#!/Trade/Trade_get)  * [OrderBook Data](#!/OrderBook/OrderBook_getL2)  * [Settlement Data](#!/Settlement/Settlement_get)  * [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)    ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

/*
 * SWGUserCommission.h
 *
 * 
 */

#ifndef SWGUserCommission_H_
#define SWGUserCommission_H_

#include <QJsonObject>



#include "SWGObject.h"

namespace Swagger {

class SWGUserCommission: public SWGObject {
public:
    SWGUserCommission();
    SWGUserCommission(QString json);
    ~SWGUserCommission();
    void init();
    void cleanup();

    QString asJson () override;
    QJsonObject asJsonObject() override;
    void fromJsonObject(QJsonObject json) override;
    SWGUserCommission* fromJson(QString jsonString) override;

    double getMakerFee();
    void setMakerFee(double maker_fee);

    double getTakerFee();
    void setTakerFee(double taker_fee);

    double getSettlementFee();
    void setSettlementFee(double settlement_fee);

    double getMaxFee();
    void setMaxFee(double max_fee);


    virtual bool isSet() override;

private:
    double maker_fee;
    bool m_maker_fee_isSet;

    double taker_fee;
    bool m_taker_fee_isSet;

    double settlement_fee;
    bool m_settlement_fee_isSet;

    double max_fee;
    bool m_max_fee_isSet;

};

}

#endif /* SWGUserCommission_H_ */