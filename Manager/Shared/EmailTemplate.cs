using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Shared
{
    public static class EmailTemplate
    {
        public static string EmailCreatedUser(string urlActivate)
        {
            return @"<!DOCTYPE html>
					<html xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"" lang=""en"">

					<head>
						<title></title>
						<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
						<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
						<!--[if mso]><xml><o:OfficeDocumentSettings><o:PixelsPerInch>96</o:PixelsPerInch><o:AllowPNG/></o:OfficeDocumentSettings></xml><![endif]-->
						<style>
							* {
								box-sizing: border-box;
							}

							body {
								margin: 0;
								padding: 0;
							}

							a[x-apple-data-detectors] {
								color: inherit !important;
								text-decoration: inherit !important;
							}

							#MessageViewBody a {
								color: inherit;
								text-decoration: none;
							}

							p {
								line-height: inherit
							}

							.desktop_hide,
							.desktop_hide table {
								mso-hide: all;
								display: none;
								max-height: 0px;
								overflow: hidden;
							}

							@media (max-width:660px) {
								.desktop_hide table.icons-inner {
									display: inline-block !important;
								}

								.icons-inner {
									text-align: center;
								}

								.icons-inner td {
									margin: 0 auto;
								}

								.image_block img.big,
								.row-content {
									width: 100% !important;
								}

								.mobile_hide {
									display: none;
								}

								.stack .column {
									width: 100%;
									display: block;
								}

								.mobile_hide {
									min-height: 0;
									max-height: 0;
									max-width: 0;
									overflow: hidden;
									font-size: 0px;
								}

								.desktop_hide,
								.desktop_hide table {
									display: table !important;
									max-height: none !important;
								}
							}
						</style>
					</head>

					<body style=""background-color: #f8f8f9; margin: 0; padding: 0; -webkit-text-size-adjust: none; text-size-adjust: none;"">
						<table class=""nl-container"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9;"">
							<tbody>
								<tr>
									<td>
										<table class=""row row-1"" align=""center"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c;"">
											<tbody>
												<tr>
													<td>
														<table class=""row-content stack"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; color: #000000; background-color: #1aa19c; width: 640px;"" width=""640"">
															<tbody>
																<tr>
																	<td class=""column column-1"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; padding-top: 0px; padding-bottom: 0px; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"">
																		<table class=""divider_block block-1"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																			<tr>
																				<td class=""pad"">
																					<div class=""alignment"" align=""center"">
																						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																							<tr>
																								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;""><span>&#8202;</span></td>
																							</tr>
																						</table>
																					</div>
																				</td>
																			</tr>
																		</table>
																	</td>
																</tr>
															</tbody>
														</table>
													</td>
												</tr>
											</tbody>
										</table>
										<table class=""row row-2"" align=""center"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff;"">
											<tbody>
												<tr>
													<td>
														<table class=""row-content stack"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px;"" width=""640"">
															<tbody>
																<tr>
																	<td class=""column column-1"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; padding-top: 0px; padding-bottom: 0px; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"">
																		<table class=""image_block block-1"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																			<tr>
																				<td class=""pad"" style=""padding-bottom:25px;padding-top:22px;width:100%;padding-right:0px;padding-left:0px;"">
																					<div class=""alignment"" align=""center"" style=""line-height:10px""><img src=""https://d1oco4z2z1fhwp.cloudfront.net/templates/default/1361/Companify-Logo.png"" style=""display: block; height: auto; border: 0; width: 149px; max-width: 100%;"" width=""149"" alt=""I'm an image"" title=""I'm an image""></div>
																				</td>
																			</tr>
																		</table>
																	</td>
																</tr>
															</tbody>
														</table>
													</td>
												</tr>
											</tbody>
										</table>
										<table class=""row row-3"" align=""center"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
											<tbody>
												<tr>
													<td>
														<table class=""row-content stack"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; color: #000000; background-color: #f8f8f9; width: 640px;"" width=""640"">
															<tbody>
																<tr>
																	<td class=""column column-1"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; padding-top: 5px; padding-bottom: 5px; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"">
																		<table class=""divider_block block-1"" width=""100%"" border=""0"" cellpadding=""20"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																			<tr>
																				<td class=""pad"">
																					<div class=""alignment"" align=""center"">
																						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																							<tr>
																								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span>&#8202;</span></td>
																							</tr>
																						</table>
																					</div>
																				</td>
																			</tr>
																		</table>
																	</td>
																</tr>
															</tbody>
														</table>
													</td>
												</tr>
											</tbody>
										</table>
										<table class=""row row-4"" align=""center"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
											<tbody>
												<tr>
													<td>
														<table class=""row-content stack"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px;"" width=""640"">
															<tbody>
																<tr>
																	<td class=""column column-1"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; padding-top: 0px; padding-bottom: 0px; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"">
																		<table class=""divider_block block-1"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																			<tr>
																				<td class=""pad"" style=""padding-bottom:12px;padding-top:60px;"">
																					<div class=""alignment"" align=""center"">
																						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																							<tr>
																								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span>&#8202;</span></td>
																							</tr>
																						</table>
																					</div>
																				</td>
																			</tr>
																		</table>
																		<table class=""image_block block-2"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																			<tr>
																				<td class=""pad"" style=""padding-left:40px;padding-right:40px;width:100%;"">
																					<div class=""alignment"" align=""center"" style=""line-height:10px""><img class=""big"" src=""https://d1oco4z2z1fhwp.cloudfront.net/templates/default/1361/Img4_2x.jpg"" style=""display: block; height: auto; border: 0; width: 352px; max-width: 100%;"" width=""352"" alt=""I'm an image"" title=""I'm an image""></div>
																				</td>
																			</tr>
																		</table>
																		<table class=""divider_block block-3"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																			<tr>
																				<td class=""pad"" style=""padding-top:50px;"">
																					<div class=""alignment"" align=""center"">
																						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																							<tr>
																								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span>&#8202;</span></td>
																							</tr>
																						</table>
																					</div>
																				</td>
																			</tr>
																		</table>
																		<table class=""text_block block-4"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;"">
																			<tr>
																				<td class=""pad"" style=""padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;"">
																					<div style=""font-family: sans-serif"">
																						<div class style=""font-size: 12px; mso-line-height-alt: 14.399999999999999px; color: #555555; line-height: 1.2; font-family: Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;"">
																							<p style=""margin: 0; font-size: 16px; text-align: center; mso-line-height-alt: 19.2px;""><span style=""font-size:30px;color:#2b303a;""><strong>Activate your account with the activation code</strong></span></p>
																						</div>
																					</div>
																				</td>
																			</tr>
																		</table>
																		<table class=""text_block block-5"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;"">
																			<tr>
																				<td class=""pad"" style=""padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;"">
																					<div style=""font-family: sans-serif"">
																						<div class style=""font-size: 12px; font-family: Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif; mso-line-height-alt: 18px; color: #555555; line-height: 1.5;"">
																							<p style=""margin: 0; font-size: 14px; text-align: center; mso-line-height-alt: 22.5px;""><span style=""color:#808389;font-size:15px;"">Thank you for registering in the <strong><span style=""font-size:20px;"">Bills System</span></strong>, where you will be able to monitor and manage all your accounts.</span></p>
																							<p style=""margin: 0; font-size: 14px; text-align: center; mso-line-height-alt: 18px;"">&nbsp;</p>
																							<p style=""margin: 0; font-size: 14px; text-align: center; mso-line-height-alt: 22.5px;""><span style=""color:#808389;font-size:15px;"">The token below is valid for 1 day until it expires.</span></p>
																						</div>
																					</div>
																				</td>
																			</tr>
																		</table>
																		<table class=""divider_block block-6"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																			<tr>
																				<td class=""pad"" style=""padding-top:50px;"">
																					<div class=""alignment"" align=""center"">
																						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																							<tr>
																								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span>&#8202;</span></td>
																							</tr>
																						</table>
																					</div>
																				</td>
																			</tr>
																		</table>
																	</td>
																</tr>
															</tbody>
														</table>
													</td>
												</tr>
											</tbody>
										</table>
										<table class=""row row-5"" align=""center"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
											<tbody>
												<tr>
													<td>
														<table class=""row-content stack"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px;"" width=""640"">
															<tbody>
																<tr>
																	<td class=""column column-1"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; padding-top: 0px; padding-bottom: 0px; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"">
																		<table class=""button_block block-1"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																			<tr>
																				<td class=""pad"" style=""padding-left:10px;padding-right:10px;padding-top:40px;text-align:center;"">
																					<div class=""alignment"" align=""center"">
																						<a target=""_blank"" href=" + urlActivate + @" >
																							<div style=""text-decoration:none;display:inline-block;color:#ffffff;background-color:#1aa19c;border-radius:60px;width:auto;border-top:0px solid transparent;font-weight:undefined;border-right:0px solid transparent;border-bottom:0px solid transparent;border-left:0px solid transparent;padding-top:15px;padding-bottom:15px;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:16px;text-align:center;mso-border-alt:none;word-break:keep-all;""><span style=""padding-left:30px;padding-right:30px;font-size:16px;display:inline-block;letter-spacing:normal;""><span style=""margin: 0; word-break: break-word; line-height: 32px;""><strong>Activate Account</strong></span></span></div>
																						</a>
																					</div>
																				</td>
																			</tr>
																		</table>
																		<table class=""divider_block block-2"" width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																			<tr>
																				<td class=""pad"" style=""padding-bottom:12px;padding-top:60px;"">
																					<div class=""alignment"" align=""center"">
																						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" width=""100%"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"">
																							<tr>
																								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span>&#8202;</span></td>
																							</tr>
																						</table>
																					</div>
																				</td>
																			</tr>
																		</table>
																	</td>
																</tr>
															</tbody>
														</table>
													</td>
												</tr>
											</tbody>
										</table>
									</td>
								</tr>
							</tbody>
						</table><!-- End -->
					</body>

					</html>";
        }
    }
}
