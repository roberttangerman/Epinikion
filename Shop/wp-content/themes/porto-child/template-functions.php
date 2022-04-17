<?php
/**
 * Use this file for all your template filters and actions.
 * Requires WooCommerce PDF Invoices & Packing Slips 1.4.13 or higher
 */
if ( ! defined( 'ABSPATH' ) ) exit; // Exit if accessed directly

function wpo_wcpdf_tax_exempt($document_type, $order)
{
    // only in financial documents
    if(!in_array($document_type, array('invoice')))
    {
        return;
    }

     // get shop location
     $shop_base_location = wc_get_base_location();
     
     // refund orders don't store all tax data that the parent does
     $tax_order = $order->get_type() == 'shop_order_refund' ?  wc_get_order( $order->get_parent_id() ) : clone $order;
     
     // get billing country
     $billing_country = $tax_order->get_billing_country();
  
     // check if any tax was charged and if billing country is outside of shop base country
     if ( $tax_order->get_total_tax() == 0 && $billing_country != $shop_base_location['country'] ) 
     {
         ?>
         <div class="tax-exempt">
            English: Tax free under intra-community supply.<br/>
            Dutch: Vrijgesteld van btw, overeenkomstig art. 39 WBTW
         </div>
         <?php
     }
}

add_action('wpo_wcpdf_after_order_details', 'wpo_wcpdf_tax_exempt', 10, 2);
