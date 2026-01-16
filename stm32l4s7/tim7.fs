\
\ @file tim7.fs
\ @brief TIM7 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM7 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM7_TIM7_CR1_CEN                                \ Counter enable Note: Gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware. CEN is cleared automatically in one-pulse mode, when an update event occurs.
$00000002 constant TIM7_TIM7_CR1_UDIS                               \ Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
$00000004 constant TIM7_TIM7_CR1_URS                                \ Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
$00000008 constant TIM7_TIM7_CR1_OPM                                \ One-pulse mode
$00000080 constant TIM7_TIM7_CR1_ARPE                               \ Auto-reload preload enable
$00000800 constant TIM7_TIM7_CR1_UIFREMAP                           \ UIF status bit remapping


\
\ @brief TIM7 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM7_TIM7_CR2_MMS                                \ Master mode selection These bits are used to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows: When the Counter Enable signal is controlled by the trigger input, there is a delay on TRGO, except if the master/slave mode is selected (see the MSM bit description in the TIMx_SMCR register). Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.


\
\ @brief TIM7 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM7_TIM7_DIER_UIE                               \ Update interrupt enable
$00000100 constant TIM7_TIM7_DIER_UDE                               \ Update DMA request enable


\
\ @brief TIM7 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM7_TIM7_SR_UIF                                 \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow regarding the repetition counter value and if UDIS = 0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in the TIMx_EGR register, if URS = 0 and UDIS = 0 in the TIMx_CR1 register.


\
\ @brief TIM7 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM7_TIM7_EGR_UG                                 \ Update generation This bit can be set by software, it is automatically cleared by hardware.


\
\ @brief TIM7 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM7_TIM7_CNT_CNT                                \ Counter value
$80000000 constant TIM7_TIM7_CNT_UIFCPY                             \ UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in TIMx_CR1 is reset, bit 31 is reserved and read as 0.


\
\ @brief TIM7 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM7_TIM7_PSC_PSC                                \ Prescaler value The counter clock frequency CK_CNT is equal to f<sub>CK_PSC</sub> / (PSC[15:0] + 1). PSC contains the value to be loaded into the active prescaler register at each update event. (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in reset mode ).


\
\ @brief TIM7 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM7_TIM7_ARR_ARR                                \ Prescaler value ARR is the value to be loaded into the actual auto-reload register. Refer to Section 46.3.1: Time-base unit on page 1760 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.


\
\ @brief TIM7 address block description
\
$40001400 constant TIM7_TIM7_CR1  \ offset: 0x00 : TIM7 control register 1
$40001404 constant TIM7_TIM7_CR2  \ offset: 0x04 : TIM7 control register 2
$4000140c constant TIM7_TIM7_DIER  \ offset: 0x0C : TIM7 DMA/Interrupt enable register
$40001410 constant TIM7_TIM7_SR   \ offset: 0x10 : TIM7 status register
$40001414 constant TIM7_TIM7_EGR  \ offset: 0x14 : TIM7 event generation register
$40001424 constant TIM7_TIM7_CNT  \ offset: 0x24 : TIM7 counter
$40001428 constant TIM7_TIM7_PSC  \ offset: 0x28 : TIM7 prescaler
$4000142c constant TIM7_TIM7_ARR  \ offset: 0x2C : TIM7 auto-reload register

